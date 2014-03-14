using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class FareComponent
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string ComponentType { get; set; }
        public decimal Amount { get; set; }
        public string ChargeType { get; set; }
        public long RateCodeId { get; set; }
        public virtual RateCode RateCode { get; set; }
    }
}
