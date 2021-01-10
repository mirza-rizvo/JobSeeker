using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Request.Town;
using PlatformForJobSeeking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TownController : Controller
    {


        private TownService _townService;

        public TownController(PlatformDbContext platformDbContext)
        {
            _townService = new TownService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            return Ok(_townService.GetTownById(Id));
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateTown town)
        {
            return Ok(_townService.CreateTown(town));
        }

        [HttpPut("{id}")]
        public IActionResult Put([FromBody] string townName, string id)
        {
            _townService.UpdateTown(id, townName);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            _townService.DeleteTown(Id);
            return NoContent();
        }
    }
}
