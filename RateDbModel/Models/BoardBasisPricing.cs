using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class BoardBasisPricing
    {
        public BoardBasisPricing()
        {
            this.BoardBasisRates = new List<BoardBasisRate>();
        }

        public long Id { get; set; }
        public long HotelBoardBasisId { get; set; }
        public string CurrencyCode { get; set; }
        public string Type { get; set; }
        public string AddedBy { get; set; }
        public string LastModifiedBy { get; set; }
        public System.DateTime AddedOn { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string Scope { get; set; }
        public virtual ICollection<BoardBasisRate> BoardBasisRates { get; set; }
    }
}
