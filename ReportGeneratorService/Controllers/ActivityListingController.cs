using System.Linq;
using System.Web.Http;
using ContentDbModel.Models;
using Provider.IMSDBProvider;
using ProviderInterfaces;
using ReportGeneratorService.Models;
using HotelRow = ReportGeneratorService.Models.HotelRow;

namespace ReportGeneratorService.Controllers
{
    public class ActivityListingController : ApiController
    {
        private readonly IContentProvider _contentProvider = new ContentDbProvider();

        public ActivityListingResponse GetHotelRows(string activityName, string cityName, string tagName, int top, int skip)
        {

            var request = new ContentDbModel.Models.ActivityListingRequest()
            {
                ActivityName = activityName,
                CityName = cityName,
                Skip = skip,
                TagName = tagName,
                Top = top
            };

            HotelListingResponse response = _contentProvider.GetUserHotels(request);

            return new ActivityListingResponse()
            {
                HotelRows = response.HotelRows.Select(row => new Models.HotelRow()
                {
                    Address = row.Address,
                    Id = row.Id,
                    Name = row.Name,
                    Phone = row.Phone

                }).ToList(),
                PaginationInfo = new Models.PaginationInfo()
                {
                    Start = response.PaginationInfo.Start,
                    Stop = response.PaginationInfo.Stop,
                    Total = response.PaginationInfo.Total
                }
            };
        }

        public HotelRow GetHotelRow(long id)
        {
            var userHotel = _contentProvider.GetUserHotel(id, "1799");
            return new Models.HotelRow()
            {
                Address = userHotel.Address,
                Phone = userHotel.Phone,
                Name = userHotel.Name,
                Id = userHotel.Id
            };
        }

    }
}
