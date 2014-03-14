using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class HotelRateCode
    {
        public long Id { get; set; }
        public long RateCodeId { get; set; }
        public string CheckInDays { get; set; }
        public string CheckOutDays { get; set; }
        public Nullable<int> MinimumStay { get; set; }
        public Nullable<int> MaximumStay { get; set; }
        public virtual RateCode RateCode { get; set; }
    }
}
