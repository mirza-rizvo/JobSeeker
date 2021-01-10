using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {


        private UserService userService;

        public object UserName { get; private set; }

        public UserController(PlatformDbContext platformDbContext)
        {
            userService = new UserService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            return Ok(userService.GetUserById(Id));
        }

        [HttpPost]
        public IActionResult PostAdvert([FromBody] string RegionName)
        {
            return Ok(userService.CreateUser(UserName));
        }

        [HttpPut("{id}")]
        public IActionResult PutAdvert([FromBody] string userName, string id)
        {
            userService.UpdateUser(id, UserName);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            userService.DeleteUser(Id);
            return NoContent();
        }
    }
}
