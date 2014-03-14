using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ReportGeneratorService.Models
{
    [DataContract]
    public class ActivityListingResponse
    {
        [DataMember(Name = "HotelRows")]
        public List<HotelRow> HotelRows { get; set; }

        [DataMember(Name = "PaginationInfo")]
        public PaginationInfo PaginationInfo { get; set; }

    }
}