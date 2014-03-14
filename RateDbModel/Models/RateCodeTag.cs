using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class RateCodeTag
    {
        public long Id { get; set; }
        public long RateCodeId { get; set; }
        public long TagId { get; set; }
        public virtual RateCode RateCode { get; set; }
        public virtual Tag Tag { get; set; }
    }
}
