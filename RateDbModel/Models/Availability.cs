using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class Availability
    {
        public long ProductId { get; set; }
        public long InventoryId { get; set; }
        public long RateCodeId { get; set; }
        public long RateId { get; set; }
        public System.DateTime AvailableDate { get; set; }
        public int Allocated { get; set; }
        public int Booked { get; set; }
        public string ProductType { get; set; }
    }
}
