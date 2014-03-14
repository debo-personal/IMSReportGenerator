using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class ActivityOption
    {
        public ActivityOption()
        {
            this.ActivityBlackOutPeriods = new List<ActivityBlackOutPeriod>();
        }

        public long Id { get; set; }
        public long ActivityId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> MaxAdults { get; set; }
        public Nullable<int> MaxChildren { get; set; }
        public Nullable<int> MinTotal { get; set; }
        public Nullable<int> MaxTotal { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string UnitName { get; set; }
        public string PricingType { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public string Scope { get; set; }
        public virtual Activity Activity { get; set; }
        public virtual ICollection<ActivityBlackOutPeriod> ActivityBlackOutPeriods { get; set; }
    }
}
