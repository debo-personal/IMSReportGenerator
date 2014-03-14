using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class Activity
    {
        public Activity()
        {
            this.ActivityOptions = new List<ActivityOption>();
        }

        public long Id { get; set; }
        public string Code { get; set; }
        public string Category { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Vendor { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneCountryCode { get; set; }
        public string Email { get; set; }
        public string ContactName { get; set; }
        public string WeekEndDays { get; set; }
        public bool IsEnabled { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public string Scope { get; set; }
        public bool IsDeleted { get; set; }
        public virtual ICollection<ActivityOption> ActivityOptions { get; set; }
    }
}
