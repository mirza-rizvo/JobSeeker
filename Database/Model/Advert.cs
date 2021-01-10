using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Database.Model
{
    public class Advert
    {
        public string Id { get; set; }
        public string AdName { get; set; }
        public string AdDescription { get; set; }
        public DateTime DateCreated { get; set; }
        public int AdDuration { get; set; }
        public int NumberOfSeekers { get; set; }

        public string AdvertTypeId { get; set; }
        public AdvertType AdvertType { get; set; }
        public string TownId { get; set; }
        public Town Town { get; set; }
      
    }
}
