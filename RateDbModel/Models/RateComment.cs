using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class RateComment
    {
        public long Id { get; set; }
        public long RateId { get; set; }
        public string Comment { get; set; }
        public string AddedBy { get; set; }
        public string AddedByName { get; set; }
        public System.DateTime AddedOn { get; set; }
        public virtual Rate Rate { get; set; }
    }
}
