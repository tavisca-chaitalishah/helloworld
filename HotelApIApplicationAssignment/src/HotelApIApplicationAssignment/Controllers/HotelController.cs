using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HotelApIApplicationAssignment.Models;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Logging;

namespace HotelApIApplicationAssignment.Controllers
{
    [Route("api/hotel")]
    public class HotelController : Controller
    {


        private readonly IManagable _manager;
        private readonly IDistributedCache _distributedCache;
        private JsonSerialization _serializable = new JsonSerialization();

        public HotelController(IManagable manager, IDistributedCache distributedCache)
        {
            _manager = manager;
            _distributedCache = distributedCache;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            byte[] hotel = await _distributedCache.GetAsync("hotelValue");
            List<Hotel> hotels = null;
            if (hotel == null)
            {
                hotels = _manager.GetHotels();
                await _distributedCache.SetAsync("hotelValue", _serializable.serialization(hotels));
                return Ok(hotels);
            }
            else
                return Ok(_serializable.Deserialization(hotel));

        }

        [HttpGet("{city}")]
        public IActionResult Search(string city)
        {
            var hotels = _manager.GetHotels(city);

            if (hotels == null)
            {
                return BadRequest($"No hotels in {city} city.");
            }
            return Ok(hotels);

        }
        [HttpPost]
        public IActionResult Post([FromBody]Hotel hotel)
        {
            var hotelToChange = _manager.updateHotelDescription(hotel);
            return NoContent();
        }
        [HttpPut]
        public async Task<IActionResult> Put([FromBody]Hotel hotel)
        {
            _manager.InsertHotel(hotel);
            await _distributedCache.RemoveAsync("hotelValue");
            return NoContent();
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([FromBody]Hotel hotel)
        {
            _manager.deleteHotel(hotel);
            await _distributedCache.RemoveAsync("hotelValue");
            return Ok();
        }
    }
}
