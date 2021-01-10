using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Database.Model
{
    public class Town
    {
        public string Id { get; set; }
        public string TownName { get; set; }
        public string RegionId { get; set; }
        public Region Region { get; set; }
    }
}
