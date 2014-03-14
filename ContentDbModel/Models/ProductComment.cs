using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class ProductComment
    {
        public long Id { get; set; }
        public long ProductId { get; set; }
        public string ProductType { get; set; }
        public string Comment { get; set; }
        public string AddedBy { get; set; }
        public string AddedByName { get; set; }
        public System.DateTime AddedOn { get; set; }
        public string Scope { get; set; }
        public virtual ProductType ProductType1 { get; set; }
    }
}
