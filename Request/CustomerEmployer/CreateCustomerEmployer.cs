using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Request.CustomerEmployer
{
    public class CreateCustomerEmployer
    {
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string DateOfEstablishment { get; set; }
        public string CompanyActivities { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

    }
}
