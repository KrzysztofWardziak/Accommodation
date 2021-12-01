using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccommodationWebApi.Model
{
    public class AccommodationSetting
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Prices> Prices { get; set; }

    }

    public class Prices
    {
        public int Date { get; set; }
        public int Price { get; set; }
    }
}
