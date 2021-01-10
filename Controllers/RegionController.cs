using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegionController : Controller
    {


        private RegionService regionService;

        public RegionController(PlatformDbContext platformDbContext)
        {
            regionService = new RegionService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            return Ok(regionService.GetRegionById(Id));
        }

        [HttpPost]
        public IActionResult PostAdvert([FromBody] string RegionName)
        {
            return Ok(regionService.CreateRegion(RegionName));
        }

        [HttpPut("{id}")]
        public IActionResult PutAdvert([FromBody] string regionName, string id)
        {
            regionService.UpdateRegion(id, regionName);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            regionService.DeleteRegion(Id);
            return NoContent();
        }
    }
}
