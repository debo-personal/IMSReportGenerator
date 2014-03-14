using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContentDbModel.Models;

namespace ProviderInterfaces
{
    public interface IContentProvider
    {
        HotelRow GetUserHotel(long id, string scope);
        HotelListingResponse GetUserHotels(ActivityListingRequest activityListingRequest);

    }
}
