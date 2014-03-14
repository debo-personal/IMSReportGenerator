using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class RateContractPolicy
    {
        public RateContractPolicy()
        {
            this.RateContracts = new List<RateContract>();
        }

        public int Id { get; set; }
        public Nullable<int> MinAdvancePurchaseDays { get; set; }
        public Nullable<int> MaxAdvancePurchaseDays { get; set; }
        public string CheckInDays { get; set; }
        public string CheckOutDays { get; set; }
        public Nullable<int> MinimumStay { get; set; }
        public Nullable<int> MaximumStay { get; set; }
        public Nullable<bool> IsCheckinAllowed { get; set; }
        public Nullable<bool> IsCheckoutAllowed { get; set; }
        public string GeneralPolicies { get; set; }
        public Nullable<bool> IsNonRefundable { get; set; }
        public virtual ICollection<RateContract> RateContracts { get; set; }
    }
}
