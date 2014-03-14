using System.Runtime.Serialization;

namespace ReportGeneratorService.Models
{
    [DataContract]
    public class Login
    {
        [DataMember(Name = "UserName")]
        public string UserName { get; set; }

        [DataMember(Name = "Scope")]
        public string Scope { get; set; }

        [DataMember(Name = "Password")]
        public string Password { get; set; }
    }
}