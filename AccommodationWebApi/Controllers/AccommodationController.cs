using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AccommodationWebApi.Model;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using JsonSerializer = System.Text.Json.JsonSerializer;

namespace AccommodationWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccommodationController : ControllerBase
    {
        private readonly IConfiguration _configuration;

        public AccommodationController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var accommodationSetting = new List<AccommodationSetting>();
            _configuration.Bind("Accommodations", accommodationSetting);
            var options = new JsonSerializerOptions() {WriteIndented = true};
            var jsonString = JsonSerializer.Serialize(accommodationSetting, options);
            return Content(jsonString);
        }
    }
}
