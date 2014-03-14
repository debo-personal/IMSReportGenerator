using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class Penalty
    {
        public long Id { get; set; }
        public decimal Amount { get; set; }
        public string PenaltyType { get; set; }
        public string ChargeType { get; set; }
        public Nullable<int> ApplicableDurationBeforeCheckin { get; set; }
        public string DurationType { get; set; }
        public Nullable<long> RateCodeId { get; set; }
        public Nullable<long> RateContractId { get; set; }
        public virtual RateCode RateCode { get; set; }
        public virtual RateContract RateContract { get; set; }
    }
}
