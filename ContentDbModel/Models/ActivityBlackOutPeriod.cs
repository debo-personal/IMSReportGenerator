using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class ActivityBlackOutPeriod
    {
        public long Id { get; set; }
        public long OptionId { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime EndDate { get; set; }
        public virtual ActivityOption ActivityOption { get; set; }
    }
}
