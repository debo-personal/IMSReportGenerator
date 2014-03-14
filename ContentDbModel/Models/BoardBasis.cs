using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class BoardBasis
    {
        public BoardBasis()
        {
            this.HotelBoardBasises = new List<HotelBoardBasis>();
        }

        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsStandard { get; set; }
        public string Scope { get; set; }
        public virtual ICollection<HotelBoardBasis> HotelBoardBasises { get; set; }
    }
}
