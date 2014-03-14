using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class UserHotel
    {
        public UserHotel()
        {
            this.HotelAmenities = new List<HotelAmenity>();
            this.HotelBoardBasises = new List<HotelBoardBasis>();
        }

        public long ClarifiHotelMappingId { get; set; }
        public string HotelName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string CityCode { get; set; }
        public string CityName { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public Nullable<decimal> Latitude { get; set; }
        public Nullable<decimal> Longitude { get; set; }
        public bool StopSale { get; set; }
        public string ChainCode { get; set; }
        public string WebsiteUrl { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string AddedBy { get; set; }
        public System.DateTime LastModifiedOn { get; set; }
        public string LastModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string Scope { get; set; }
        public string PhoneCountryCode { get; set; }
        public virtual ClarifiHotelMapping ClarifiHotelMapping { get; set; }
        public virtual ICollection<HotelAmenity> HotelAmenities { get; set; }
        public virtual ICollection<HotelBoardBasis> HotelBoardBasises { get; set; }
    }
}
