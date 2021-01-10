using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Database.Model
{
    public class User
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public string UserName { get; set; }
        public string RoleId { get; set; }
        public Role Role { get; set; }



    }
}
