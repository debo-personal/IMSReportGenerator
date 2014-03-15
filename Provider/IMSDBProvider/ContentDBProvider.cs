using System;
using System.Collections.Generic;
using System.Linq;
using ContentDbModel.Models;
using ProviderInterfaces;

namespace Provider.IMSDBProvider
{
    public class ContentDbProvider : IContentProvider
    {
        public HotelRow GetUserHotel(long id, string scope)
        {
            using (var db = new TaviscaCatapultDatabaseContentContext())
            {
                var hotel = db.UserHotels.Find(id, scope);
                return new HotelRow()
                {
                    Address = string.Format("{0} {1} {2} {3} {4}", hotel.Address1, hotel.Address2, hotel.CityName, hotel.StateName, hotel.CountryCode),
                    Phone = hotel.PhoneNumber,
                    Id = hotel.ClarifiHotelMappingId,
                    Name = hotel.HotelName
                };

            }
        }

        public HotelListingResponse GetUserHotels(HotelListingRequest hotelListingRequest)
        {
            using (var db = new TaviscaCatapultDatabaseContentContext())
            {

                var count = db.UserHotels.Count();

                List<UserHotel> hotels = (from userHotel in db.UserHotels
                                          where (hotelListingRequest.HotelName == null || hotelListingRequest.HotelName == "" || userHotel.HotelName.Contains(hotelListingRequest.HotelName)) &&
                                                (hotelListingRequest.CityName == null || hotelListingRequest.CityName == "" || (userHotel.CityName.Contains(hotelListingRequest.CityName) ||
                                                 userHotel.CityCode.Contains(hotelListingRequest.CityName)))

                                          select userHotel).OrderBy(d => d.ClarifiHotelMappingId).Skip(hotelListingRequest.Skip).Take(hotelListingRequest.Top).ToList();
                return new HotelListingResponse()
                {
                    HotelRows = hotels.Select(hotel => new HotelRow()
                    {
                        Address =
                            string.Format("{0} {1} {2} {3} {4}", hotel.Address1, hotel.Address2, hotel.CityName,
                                hotel.StateName, hotel.CountryCode),
                        Phone = hotel.PhoneNumber,
                        Id = hotel.ClarifiHotelMappingId,
                        Name = hotel.HotelName
                    }).ToList(),

                    PaginationInfo = new PaginationInfo()
                    {
                        Start = hotelListingRequest.Skip + 1,
                        Stop = Math.Min(count, hotelListingRequest.Top + hotelListingRequest.Skip),
                        Total = count
                    }
                };
            }
        }
    }
}
