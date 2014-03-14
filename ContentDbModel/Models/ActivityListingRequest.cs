namespace ContentDbModel.Models
{
    public class ActivityListingRequest
    {
        public string ActivityName { get; set; }

        public string CityName { get; set; }

        public string TagName { get; set; }

        public int Top { get; set; }

        public int Skip { get; set; }
    }
}