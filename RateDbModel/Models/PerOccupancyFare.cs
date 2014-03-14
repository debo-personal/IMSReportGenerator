using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class PerOccupancyFare
    {
        public PerOccupancyFare()
        {
            this.RateContractOccupancyFareMappings = new List<RateContractOccupancyFareMapping>();
            this.RateContractOccupancyFareMappings1 = new List<RateContractOccupancyFareMapping>();
        }

        public long Id { get; set; }
        public decimal Rate { get; set; }
        public decimal ExtraAdult { get; set; }
        public decimal ExtraChildWithBed { get; set; }
        public decimal ExtraChildWithoutBed { get; set; }
        public decimal ExtraInfant { get; set; }
        public virtual ICollection<RateContractOccupancyFareMapping> RateContractOccupancyFareMappings { get; set; }
        public virtual ICollection<RateContractOccupancyFareMapping> RateContractOccupancyFareMappings1 { get; set; }
    }
}
