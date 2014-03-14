using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class Rate
    {
        public Rate()
        {
            this.RateComments = new List<RateComment>();
            this.RateContracts = new List<RateContract>();
        }

        public long Id { get; set; }
        public long RateCodeId { get; set; }
        public long InventoryId { get; set; }
        public string ProductType { get; set; }
        public string PricingType { get; set; }
        public string Scope { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<RateComment> RateComments { get; set; }
        public virtual ICollection<RateContract> RateContracts { get; set; }
        public virtual RateCode RateCode { get; set; }
    }
}
