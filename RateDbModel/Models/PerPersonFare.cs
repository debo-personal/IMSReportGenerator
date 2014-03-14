using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class PerPersonFare
    {
        public long Id { get; set; }
        public decimal Adult { get; set; }
        public decimal Child { get; set; }
        public decimal ExtraAdult { get; set; }
        public decimal ExtraChild { get; set; }
    }
}
