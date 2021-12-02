using System;
using System.Collections.Generic;
using System.Text;
using AccommodationWebApi.Domain.Model;

namespace AccommodationWebApi.Domain.InterfaceRepository
{
    public interface IAccommodationRepository
    {
        List<AccommodationSetting> GetAllHotels();
        string GetHotelsWithLowestPrice();
        List<Prices> GetAllAccommodationByGivenId(int id);
    }
}
