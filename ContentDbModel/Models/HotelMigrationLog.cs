using System;
using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public partial class HotelMigrationLog
    {
        public long NewId { get; set; }
        public long OldId { get; set; }
        public string TableName { get; set; }
    }
}
