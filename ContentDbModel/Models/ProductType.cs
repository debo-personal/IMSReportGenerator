using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class ProductType
    {
        public ProductType()
        {
            this.AdditionalInformations = new List<AdditionalInformation>();
            this.Images = new List<Image>();
            this.ProductComments = new List<ProductComment>();
        }

        public string ProductType1 { get; set; }
        public virtual ICollection<AdditionalInformation> AdditionalInformations { get; set; }
        public virtual ICollection<Image> Images { get; set; }
        public virtual ICollection<ProductComment> ProductComments { get; set; }
    }
}
