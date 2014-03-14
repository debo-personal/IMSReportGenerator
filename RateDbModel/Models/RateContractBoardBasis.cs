using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class RateContractBoardBasis
    {
        public long RateContractId { get; set; }
        public long HotelBoardBasisId { get; set; }
        public virtual RateContract RateContract { get; set; }
    }
}
