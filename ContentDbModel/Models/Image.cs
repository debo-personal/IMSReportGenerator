using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class Image
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductType { get; set; }
        public string ImageUrl { get; set; }
        public string Caption { get; set; }
        public virtual ProductType ProductType1 { get; set; }
    }
}
