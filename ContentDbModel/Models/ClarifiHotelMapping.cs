using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class ClarifiHotelMapping
    {
        public ClarifiHotelMapping()
        {
            this.HotelRooms = new List<HotelRoom>();
            this.HotelSecondaryInformations = new List<HotelSecondaryInformation>();
            this.UserHotels = new List<UserHotel>();
        }

        public long Id { get; set; }
        public Nullable<long> ClarifiHotelId { get; set; }
        public bool IsNewHotel { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public virtual ICollection<HotelRoom> HotelRooms { get; set; }
        public virtual ICollection<HotelSecondaryInformation> HotelSecondaryInformations { get; set; }
        public virtual ICollection<UserHotel> UserHotels { get; set; }
    }
}
