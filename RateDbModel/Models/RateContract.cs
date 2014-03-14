using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class RateContract
    {
        public RateContract()
        {
            this.Penalties = new List<Penalty>();
            this.RateContractBoardBasises = new List<RateContractBoardBasis>();
            this.RateContractOccupancyFareMappings = new List<RateContractOccupancyFareMapping>();
        }

        public long Id { get; set; }
        public long RateId { get; set; }
        public System.DateTime AvailableFrom { get; set; }
        public System.DateTime AvailableTo { get; set; }
        public Nullable<int> MaxAvailabilty { get; set; }
        public bool IsWeekendRateDifferent { get; set; }
        public bool IsFreeSale { get; set; }
        public long WeekEndFare { get; set; }
        public long MidweekFare { get; set; }
        public string BookingType { get; set; }
        public bool IsDefaultBoardBasisApplicable { get; set; }
        public Nullable<int> OverridePoliciesId { get; set; }
        public virtual ICollection<Penalty> Penalties { get; set; }
        public virtual Rate Rate { get; set; }
        public virtual ICollection<RateContractBoardBasis> RateContractBoardBasises { get; set; }
        public virtual ICollection<RateContractOccupancyFareMapping> RateContractOccupancyFareMappings { get; set; }
        public virtual RateContractPolicy RateContractPolicy { get; set; }
    }
}
