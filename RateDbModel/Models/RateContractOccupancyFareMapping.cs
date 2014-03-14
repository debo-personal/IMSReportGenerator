using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class RateContractOccupancyFareMapping
    {
        public long RateContractId { get; set; }
        public long OccupancyId { get; set; }
        public long WeekdayFareId { get; set; }
        public Nullable<long> WeekendFareId { get; set; }
        public bool IsWeekendFareSeparate { get; set; }
        public virtual Occupancy Occupancy { get; set; }
        public virtual PerOccupancyFare PerOccupancyFare { get; set; }
        public virtual PerOccupancyFare PerOccupancyFare1 { get; set; }
        public virtual RateContract RateContract { get; set; }
    }
}
