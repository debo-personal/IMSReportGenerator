using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class PerUnitFare
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public decimal ExtraAdult { get; set; }
        public decimal ExtraChild { get; set; }
    }
}
