using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class HotelRoomBlackoutPeriod
    {
        public long Id { get; set; }
        public long HotelRoomId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public virtual HotelRoom HotelRoom { get; set; }
    }
}
