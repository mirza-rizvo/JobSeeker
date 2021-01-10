using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Request.AdvertType;
using PlatformForJobSeeking.Services;

namespace PlatformForJobSeeking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdvertTypeController : Controller
    {
        private AdvertTypesService advertTypeService;

        public AdvertTypeController(PlatformDbContext platformDbContext)
        {
            advertTypeService = new AdvertTypesService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            return Ok(advertTypeService.GetAdvertTypeById(id));
        }

        [HttpPost]
        public IActionResult PostAdvert([FromBody] CreateAdvertType advertTypes)
        {
            return Ok(advertTypeService.CreateAdvertType(advertTypes));
        }

        [HttpPut("{id}")]
        public IActionResult PutAdvert([FromBody] UpdateAdvertType advert, string id)
        {
            advertTypeService.UpdateAdvertType(id, advert);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            advertTypeService.DeleteAdvertType(Id);
            return NoContent();
        }
    }
}