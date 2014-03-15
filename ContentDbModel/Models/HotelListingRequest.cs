namespace ContentDbModel.Models
{
    public class HotelListingRequest
    {
        public string HotelName { get; set; }

        public string CityName { get; set; }

        public string TagName { get; set; }

        public int Top { get; set; }

        public int Skip { get; set; }
    }
}