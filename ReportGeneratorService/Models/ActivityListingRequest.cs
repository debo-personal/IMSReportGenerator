using System.Runtime.Serialization;

namespace ReportGeneratorService.Models
{
    [DataContract]
    public class ActivityListingRequest
    {
        [DataMember(Name = "ActivityName")]
        public string ActivityName { get; set; }

        [DataMember(Name = "CityName")]
        public string CityName { get; set; }

        [DataMember(Name = "TagName")]
        public string TagName { get; set; }

        [DataMember(Name = "Top")]
        public int Top { get; set; }

        [DataMember(Name = "Skip")]
        public int Skip { get; set; }
    }
}