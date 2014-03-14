using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class Amenity
    {
        public Amenity()
        {
            this.HotelAmenities = new List<HotelAmenity>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public bool IsStandard { get; set; }
        public virtual ICollection<HotelAmenity> HotelAmenities { get; set; }
    }
}
