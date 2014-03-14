using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class HotelRoom
    {
        public HotelRoom()
        {
            this.HotelRoomBlackoutPeriods = new List<HotelRoomBlackoutPeriod>();
        }

        public long Id { get; set; }
        public long UserHotelId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> IsAgeRequired { get; set; }
        public Nullable<int> MaxCapacity { get; set; }
        public string BedType { get; set; }
        public Nullable<int> BedCount { get; set; }
        public string SaleType { get; set; }
        public Nullable<bool> IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public string Scope { get; set; }
        public virtual ClarifiHotelMapping ClarifiHotelMapping { get; set; }
        public virtual ICollection<HotelRoomBlackoutPeriod> HotelRoomBlackoutPeriods { get; set; }
    }
}
