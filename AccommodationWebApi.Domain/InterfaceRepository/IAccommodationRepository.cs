using System;
using System.Collections.Generic;
using System.Text;
using AccommodationWebApi.Domain.Model;

namespace AccommodationWebApi.Domain.InterfaceRepository
{
    public interface IAccommodationRepository
    {
        string GetHotelsWithLowestPrice();
        List<Prices> GetAllAccommodationByGivenId(int id);
    }
}
