using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Request.CustomerSeeker;
using PlatformForJobSeeking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerSeekerController : Controller
    {

        private CustomerSeekerService customerSeekerService;

        public CustomerSeekerController(PlatformDbContext platformDbContext)
        {
            customerSeekerService = new CustomerSeekerService(platformDbContext);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string Id)
        {
            return Ok(customerSeekerService.GetCustomerSeekerById(Id));
        }

        [HttpPost]
        public IActionResult PostAdvert([FromBody] CreateCustomerSeeker createCustomerSeeker)
        {
            return Ok(customerSeekerService.CreateCustomerSeeker(createCustomerSeeker));
        }

        [HttpPut("{id}")]
        public IActionResult PutAdvert([FromBody] UpdateCustomerSeeker updateCustomerEmployer, string id)
        {
            customerSeekerService.UpdateCustomerSeeker(id, updateCustomerEmployer);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAdvert(string Id)
        {
            customerSeekerService.DeleteUserById(Id);
            return NoContent();
        }
    }
}
