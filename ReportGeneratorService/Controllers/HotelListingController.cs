using System.Linq;
using System.Web.Http;
using ContentDbModel.Models;
using Provider.IMSDBProvider;
using ProviderInterfaces;

namespace ReportGeneratorService.Controllers
{
    public class HotelListingController : ApiController
    {
        private readonly IContentProvider _contentProvider = new ContentDbProvider();

        public HotelListingResponse GetHotelRows(string activityName, string cityName, string tagName, int top, int skip)
        {

            var request = new ContentDbModel.Models.HotelListingRequest()
            {
                HotelName = activityName,
                CityName = cityName,
                Skip = skip,
                TagName = tagName,
                Top = top
            };

            return _contentProvider.GetUserHotels(request);
        }

        public HotelRow GetHotelRow(long id)
        {
            return _contentProvider.GetUserHotel(id, "1799");
        }

    }
}
