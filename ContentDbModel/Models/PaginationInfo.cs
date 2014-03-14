using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentDbModel.Models
{
    public class PaginationInfo
    {
        public long Total { get; set; }

        public int Start { get; set; }

        public int Stop { get; set; }
    }
}
