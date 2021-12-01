using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using AccommodationWebApi.Application.InterfaceServices;
using Microsoft.Extensions.Configuration;

namespace AccommodationWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AccommodationController : ControllerBase
    {
        private readonly IAccommodationService _accommodationService;

        public AccommodationController( IAccommodationService accommodationService)
        {
            _accommodationService = accommodationService;
        }

        [HttpGet]
        public IActionResult Feed()
        {
            var hotels = _accommodationService.GetHotelsWithLowestPrice();
            return Content(hotels);
        }

        [HttpGet("{id}")]
        public IActionResult Prices(int id)
        {
            var hotel = _accommodationService.GetAllAccommodationByGivenId(id);
            return Ok(hotel);
        }
    }
}
