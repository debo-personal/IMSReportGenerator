using System.Runtime.Serialization;

namespace ReportGeneratorService.Models
{
    [DataContract]
    public class HotelRow
    {
        [DataMember(Name = "Id")]
        public long Id { get; set; }

        [DataMember(Name = "Name")]
        public string Name { get; set; }

        [DataMember(Name = "Phone")]
        public string Phone { get; set; }

        [DataMember(Name = "Address")]
        public string Address { get; set; }
    }
}