using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

        public HotelListingResponse GetUserHotels(ActivityListingRequest activityListingRequest)
        {
            using (var db = new TaviscaCatapultDatabaseContentContext())
            {

                var count = db.UserHotels.Count();

                List<UserHotel> hotels = (from userHotel in db.UserHotels
                                          where (activityListingRequest.ActivityName == null || activityListingRequest.ActivityName == "" || userHotel.HotelName.Contains(activityListingRequest.ActivityName)) &&
                                                (activityListingRequest.CityName == null || activityListingRequest.CityName == "" || (userHotel.CityName.Contains(activityListingRequest.CityName) ||
                                                 userHotel.CityCode.Contains(activityListingRequest.CityName)))

                                          select userHotel).OrderBy(d => d.ClarifiHotelMappingId).Skip(activityListingRequest.Skip).Take(activityListingRequest.Top).ToList();
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
                        Start = activityListingRequest.Skip + 1,
                        Stop = Math.Min(count, activityListingRequest.Top + activityListingRequest.Skip),
                        Total = count
                    }
                };














                //var hotels = db.UserHotels.Where(uh => uh.Scope == scope).ToList();



                //return hotels.Select(hotel => new HotelRow()
                //{
                //    Address =
                //        string.Format("{0} {1} {2} {3} {4}", hotel.Address1, hotel.Address2, hotel.CityName,
                //            hotel.StateName, hotel.CountryCode),
                //    Phone = hotel.PhoneNumber,
                //    Id = hotel.ClarifiHotelMappingId,
                //    Name = hotel.HotelName
                //}).ToList();
            }
        }
    }
}
