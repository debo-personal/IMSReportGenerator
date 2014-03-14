using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class BoardBasisRate
    {
        public long Id { get; set; }
        public decimal Adult { get; set; }
        public decimal ChildWithBed { get; set; }
        public decimal ChildWithoutBed { get; set; }
        public decimal Infant { get; set; }
        public string AddedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime AddedOn { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string Scope { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public long BoardBasisPricingId { get; set; }
        public decimal RoomCost { get; set; }
        public virtual BoardBasisPricing BoardBasisPricing { get; set; }
    }
}
