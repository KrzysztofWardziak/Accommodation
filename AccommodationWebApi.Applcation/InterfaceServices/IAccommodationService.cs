using System;
using System.Collections.Generic;
using System.Text;
using AccommodationWebApi.Domain.Model;

namespace AccommodationWebApi.Application.InterfaceServices
{
   public interface IAccommodationService
   {
       string GetHotelsWithLowestPrice();
       List<Prices> GetAllAccommodationByGivenId(int id);
   }
}
