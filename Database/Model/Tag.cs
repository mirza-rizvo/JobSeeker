using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Database.Model
{
    public class Tag
    {
        public string Id { get; set; }
        public string TagName { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
     
    }
}
