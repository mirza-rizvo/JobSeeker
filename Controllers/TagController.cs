using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TagController : Controller
    {


        private TagService tagService;

        public TagController(PlatformDbContext platformDbContext)
        {
            tagService = new TagService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            return Ok(tagService.GetTagById(Id));
        }

        [HttpPost]
        public IActionResult PostAdvert([FromBody] string TagName)
        {
            return Ok(tagService.CreateTag(tagName: TagName));
        }

        [HttpPut("{id}")]
        public IActionResult PutAdvert([FromBody] string tagName, string id)
        {
            tagService.TagRegion(id, tagName);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            tagService.DeleteTag(Id);
            return NoContent();
        }
    }
}
