using System;
using System.Collections.Generic;
using System.Text;
using AccommodationWebApi.Application.InterfaceServices;
using AccommodationWebApi.Domain.InterfaceRepository;
using AccommodationWebApi.Domain.Model;

namespace AccommodationWebApi.Application.Services
{
    public class AccommodationService : IAccommodationService
    {
        private readonly IAccommodationRepository _accommodationRepository;

        public AccommodationService(IAccommodationRepository accommodationRepository)
        {
            _accommodationRepository = accommodationRepository;
        }

        public string GetHotelsWithLowestPrice()
        {
            var hotels = _accommodationRepository.GetHotelsWithLowestPrice();
            return hotels;
        }

        public List<Prices> GetAllAccommodationByGivenId(int id)
        {
            var hotel = _accommodationRepository.GetAllAccommodationByGivenId(id);
            return hotel;
        }
    }
}
