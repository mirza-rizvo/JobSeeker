using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Request.Town
{
    public class CreateTown
    {
        public string TownName { get; set; }
        public string RegionId { get; set; }
    }
}
