using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class City
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string StateCode { get; set; }
        public string CountryCode { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public bool IsEnabled { get; set; }
    }
}
