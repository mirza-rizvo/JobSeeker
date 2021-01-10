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
    public class RoleController : Controller
    {


        private RoleService _roleService;

        public RoleController(PlatformDbContext platformDbContext)
        {
            _roleService = new RoleService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            return Ok(_roleService.GetRoleById(Id));
        }

        [HttpPost]
        public IActionResult PostAdvert([FromBody] string roleName)
        {
            return Ok(_roleService.CreateRole(roleName));
        }

        [HttpPut("{id}")]
        public IActionResult PutAdvert([FromBody] string roleName, string id)
        {
            _roleService.UpdateRole(id, roleName);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            _roleService.DeleteRole(Id);
            return NoContent();
        }
    }
}

