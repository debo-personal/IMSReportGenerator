using System.Configuration;
using System.Linq;
using System.Web.Http;
using ContentDbModel.Models;
using Provider.IMSDBProvider;
using Provider.MockProvider;
using ProviderInterfaces;

namespace ReportGeneratorService.Controllers
{
    public class HotelListingController : ApiController
    {
        private readonly IContentProvider _contentProvider = new ContentDbProvider();
        private readonly IContentProvider _mockContentProvider = new MockContentDbProvider();

        public HotelListingResponse GetHotelRows(string activityName, string cityName, string tagName, int top, int skip)
        {

            var request = new HotelListingRequest()
            {
                HotelName = activityName,
                CityName = cityName,
                Skip = skip,
                TagName = tagName,
                Top = top
            };

            return ConfigurationManager.AppSettings["UseMockData"] == "true"
                       ? _mockContentProvider.GetUserHotels(request)
                       : _contentProvider.GetUserHotels(request);
        }

        public HotelRow GetHotelRow(long id)
        {
            return _contentProvider.GetUserHotel(id, "1799");
        }

    }
}
