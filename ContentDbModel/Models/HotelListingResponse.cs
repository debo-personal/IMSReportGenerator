using System.Collections.Generic;

namespace ContentDbModel.Models
{
    public class HotelListingResponse
    {
        public List<HotelRow> HotelRows { get; set; }

        public PaginationInfo PaginationInfo { get; set; }
    }
}
