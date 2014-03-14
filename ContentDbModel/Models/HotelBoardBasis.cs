using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class HotelBoardBasis
    {
        public long Id { get; set; }
        public string BoardBasisCode { get; set; }
        public string Name { get; set; }
        public long HotelId { get; set; }
        public string Description { get; set; }
        public string CostType { get; set; }
        public string CostUnit { get; set; }
        public string AddedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime AddedOn { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string Scope { get; set; }
        public virtual BoardBasis BoardBasis { get; set; }
        public virtual UserHotel UserHotel { get; set; }
    }
}
