using System.Web;
using System.Web.Http;
using ContentDbModel.Models;
using Provider.IMSDBProvider;
using ProviderInterfaces;
using ReportGeneratorService.Models;

namespace ReportGeneratorService.Controllers
{
    public class LoginController : ApiController
    {
        private readonly IContentProvider _contentProvider = new ContentDbProvider();

        // /IMSapi/login
        public HotelListingResponse Get(HotelListingRequest hotelListingRequest)
        {

            return _contentProvider.GetUserHotels(hotelListingRequest);

        }
        // /IMSapi/login/id
        public HotelRow Get(long id)
        {
            var userHotel = _contentProvider.GetUserHotel(id, "1799");
            return new HotelRow()
            {
                Address = userHotel.Address,
                Phone = userHotel.Phone,
                Name = userHotel.Name,
                Id = userHotel.Id
            };
        }

        public void Put(Login login)
        {
            HttpContext.Current.Session.Add(Constants.Password, login.Password);
            HttpContext.Current.Session.Add(Constants.Scope, login.Scope);
            HttpContext.Current.Session.Add(Constants.UserName, login.UserName);
        }

    }
}
