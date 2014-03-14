using System;
using System.Collections.Generic;

namespace RateDbModel.Models
{
    public partial class Tag
    {
        public Tag()
        {
            this.RateCodeTags = new List<RateCodeTag>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public virtual ICollection<RateCodeTag> RateCodeTags { get; set; }
    }
}
