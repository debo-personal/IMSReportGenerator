using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class AdditionalInformation
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductType { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Visibility { get; set; }
        public string Scope { get; set; }
        public virtual ProductType ProductType1 { get; set; }
    }
}
