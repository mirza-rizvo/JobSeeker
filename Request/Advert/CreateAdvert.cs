using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Request
{
    public class CreateAdvert
    {
        public string AdName { get; set; }
        public string AdDescription { get; set; }
        public int AdDuration { get; set; }
        public int NumberOfSeekers { get; set; }
        public string AdvertTypeId { get; set; }
        public string TownId { get; set; }
    }
}
