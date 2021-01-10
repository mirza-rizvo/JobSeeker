using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Database.Model
{
    public class CustomerEmployer
    {
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string CompanyDescription { get; set; }
        public string DateOfEstablishment { get; set; }
        public string CompanyActivities { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string UserId { get; set; }
        public User User { get; set; }
        public string TownId { get; set; }
        public Town Town { get; set; }
    }
}
