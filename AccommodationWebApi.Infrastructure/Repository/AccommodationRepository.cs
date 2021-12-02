using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using AccommodationWebApi.Domain.InterfaceRepository;
using AccommodationWebApi.Domain.Model;
using Microsoft.Extensions.Configuration;

namespace AccommodationWebApi.Infrastructure.Repository
{
    public class AccommodationRepository : IAccommodationRepository
    {
        private readonly IConfiguration _configuration;

        public AccommodationRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<AccommodationSetting> GetAllHotels()
        {
            var accommodationSetting = new List<AccommodationSetting>();
            _configuration.Bind("Accommodations", accommodationSetting);
            return accommodationSetting;
        }

        public string GetHotelsWithLowestPrice()
        {
            var accommodationSetting = GetAllHotels();
            var list = new List<Prices>();
            string jsonString = "";
            foreach (var setting in accommodationSetting)
            {
               var sortedList = setting.Prices.OrderBy(x => x.Price).ToList();
               var first =sortedList.First();
                list.Add(first);
                var options = new JsonSerializerOptions() { WriteIndented = true };
                jsonString = JsonSerializer.Serialize(list, options);
            }

            return jsonString;
        }

        public List<Prices> GetAllAccommodationByGivenId(int id)
        {
            var accommodationSetting = GetAllHotels();
            var hotel = accommodationSetting.FirstOrDefault(x => x.Id == id).Prices.OrderBy(x => x.Date).ToList();
            return hotel;
        }
    }
}
