using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class Occupancy
    {
        public Occupancy()
        {
            this.RateContractOccupancyFareMappings = new List<RateContractOccupancyFareMapping>();
        }

        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductType { get; set; }
        public string Name { get; set; }
        public int MinAdt { get; set; }
        public int MaxAdt { get; set; }
        public int RecAdt { get; set; }
        public int MinChd { get; set; }
        public int MaxChd { get; set; }
        public int RecChd { get; set; }
        public int MinChdNoBed { get; set; }
        public int MaxChdNoBed { get; set; }
        public int RecChdNoBed { get; set; }
        public int MinInf { get; set; }
        public int MaxInf { get; set; }
        public int RecInf { get; set; }
        public int MinTotal { get; set; }
        public int MaxTotal { get; set; }
        public int RecTotal { get; set; }
        public string AddedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime AddedOn { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string Scope { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<RateContractOccupancyFareMapping> RateContractOccupancyFareMappings { get; set; }
    }
}
