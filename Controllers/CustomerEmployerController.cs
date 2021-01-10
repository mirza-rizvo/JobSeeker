using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Request.CustomerEmployer;
using PlatformForJobSeeking.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerEmployerController : Controller
    {
            private CustomerEmployerService customerEmployerService;

            public CustomerEmployerController(PlatformDbContext platformDbContext)
            {
              customerEmployerService = new CustomerEmployerService(platformDbContext);
            }

            [HttpGet("{id}")]
            public IActionResult Get(string Id)
            {
                return Ok(customerEmployerService.GetCustomerEmployerById(Id));
            }

            [HttpPost]
            public IActionResult PostAdvert([FromBody] CreateCustomerEmployer customerEmployer)
            {
                return Ok(customerEmployerService.CreateCustomerEmployer(customerEmployer));
            }

            [HttpPut("{id}")]
            public IActionResult PutAdvert([FromBody] UpdateCustomerEmployer updateCustomerEmployer, string id)
            {
                customerEmployerService.UpdateCustomerEmployerById(id, updateCustomerEmployer);
                return NoContent();
            }

            [HttpDelete("{id}")]
            public IActionResult DeleteAdvert(string Id)
            {
                customerEmployerService.DeleteCustomerEmployerById(Id);
                return NoContent();
            }
        }
    }
