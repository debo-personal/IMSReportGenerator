using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class HotelAmenity
    {
        public long Id { get; set; }
        public long AmenityId { get; set; }
        public long HotelId { get; set; }
        public string Scope { get; set; }
        public virtual Amenity Amenity { get; set; }
        public virtual UserHotel UserHotel { get; set; }
    }
}
