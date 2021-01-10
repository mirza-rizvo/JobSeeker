using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Request.Advert
{
    public class UpdateAdvert
    {
        public string AdName { get; set; }
        public string AdDescription { get; set; }
        public int AdDuration { get; set; }
        public int NumberOfSeekers { get; set; }
    }
}
