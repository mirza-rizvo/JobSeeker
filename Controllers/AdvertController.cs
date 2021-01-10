using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Request;
using PlatformForJobSeeking.Request.Advert;
using PlatformForJobSeeking.Services;
using System;

namespace PlatformForJobSeeking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertController : Controller
    {
        private AdvertService advertService;

        public AdvertController(AdvertService _advertService,
        PlatformDbContext platformDbContext)
        {
            advertService = new AdvertService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            return Ok(advertService.GetAdvertById(Id));
        }

        [HttpPost]
        public IActionResult PostAdvert([FromBody] CreateAdvert advert)
        {
            return Ok(advertService.InsertAdvert(advert));
        }

        [HttpPut("{id}")]
        public IActionResult PutAdvert([FromBody] UpdateAdvert advert, string id)
        {
            advertService.UpdateAdvertById(id, advert);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            advertService.DeleteAdvertById(Id);
            return NoContent();
        }
    }
}