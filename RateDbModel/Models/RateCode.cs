using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class RateCode
    {
        public RateCode()
        {
            this.FareComponents = new List<FareComponent>();
            this.HotelRateCodes = new List<HotelRateCode>();
            this.Penalties = new List<Penalty>();
            this.Rates = new List<Rate>();
            this.RateCodeTags = new List<RateCodeTag>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Nullable<int> MinAdvancePurchaseDays { get; set; }
        public Nullable<int> MaxAdvancePurchaseDays { get; set; }
        public Nullable<System.DateTime> StartOfBookingPeriod { get; set; }
        public Nullable<System.DateTime> EndOfBookingPeriod { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public string Scope { get; set; }
        public string GeneralPolicies { get; set; }
        public string CurrencyCode { get; set; }
        public bool IsNonRefundable { get; set; }
        public string ProductType { get; set; }
        public Nullable<long> ProductId { get; set; }
        public string ContactPerson { get; set; }
        public string ContactNumber { get; set; }
        public string Email { get; set; }
        public virtual ICollection<FareComponent> FareComponents { get; set; }
        public virtual ICollection<HotelRateCode> HotelRateCodes { get; set; }
        public virtual ICollection<Penalty> Penalties { get; set; }
        public virtual ICollection<Rate> Rates { get; set; }
        public virtual ICollection<RateCodeTag> RateCodeTags { get; set; }
    }
}
