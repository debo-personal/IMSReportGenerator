using System.Runtime.Serialization;

namespace ReportGeneratorService.Models
{
    [DataContract]
    public class PaginationInfo
    {
        [DataMember(Name = "Total")]
        public long Total { get; set; }

        [DataMember(Name = "Start")]
        public int Start { get; set; }

        [DataMember(Name = "Stop")]
        public int Stop { get; set; }

    }
}