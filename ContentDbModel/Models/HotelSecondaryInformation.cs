using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class HotelSecondaryInformation
    {
        public long ClarifiHotelMappingId { get; set; }
        public string Category { get; set; }
        public string Rating { get; set; }
        public string DisplayName { get; set; }
        public string ContactPerson { get; set; }
        public string ContactEmailAddress { get; set; }
        public string ContactPhoneCountryCode { get; set; }
        public string ContactPhoneNumber { get; set; }
        public string Description { get; set; }
        public string WeekendDays { get; set; }
        public string CheckinDays { get; set; }
        public string CheckoutDays { get; set; }
        public string ContactFaxNumber { get; set; }
        public int RecommendedInfantAge { get; set; }
        public int RecommededChildWithoutBedAge { get; set; }
        public int RecommendedChildWithBedAge { get; set; }
        public string Scope { get; set; }
        public virtual ClarifiHotelMapping ClarifiHotelMapping { get; set; }
    }
}
