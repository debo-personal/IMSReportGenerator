using System;
using System.Collections.Generic;
using System.Linq;
using ContentDbModel.Models;
using ProviderInterfaces;

namespace Provider.MockProvider
{
    public class MockContentDbProvider : IContentProvider
    {
        public HotelRow GetUserHotel(long id, string scope)
        {
            return new HotelRow()
                {
                    Address = "test address for hotel 1",
                    Id = 1,
                    Name = "test hotel 1",
                    Phone = "9730266287"
                };

        }

        public HotelListingResponse GetUserHotels(HotelListingRequest hotelListingRequest)
        {
            return new HotelListingResponse()
                {
                    HotelRows = new List<HotelRow>()
                        {
                            new HotelRow()
                                {
                                    Address = "test address for hotel 1",
                                    Id = 1,
                                    Name = "test hotel 1",
                                    Phone = "9730266287"
                                },
                                
                            new HotelRow()
                                {
                                    Address = "test address for hotel 2",
                                    Id = 2,
                                    Name = "test hotel 2",
                                    Phone = "9730266287"
                                },
                            new HotelRow()
                                {
                                    Address = "test address for hotel 3",
                                    Id = 3,
                                    Name = "test hotel 3",
                                    Phone = "9730266287"
                                },
                                
                            new HotelRow()
                                {
                                    Address = "test address for hotel 4",
                                    Id = 4,
                                    Name = "test hotel 4",
                                    Phone = "9730266287"
                                },
                                
                            new HotelRow()
                                {
                                    Address = "test address for hotel 5",
                                    Id = 5,
                                    Name = "test hotel 5",
                                    Phone = "9730266287"
                                }
                        },
                    PaginationInfo = new PaginationInfo()
                        {
                            Start = 1,
                            Stop = 5,
                            Total = 5
                        }
                };
        }
    }
}
