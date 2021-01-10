using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class RegionService
    {
        PlatformDbContext _platformDbContext;

        public RegionService(PlatformDbContext platformDbContext)
        {
            _platformDbContext = platformDbContext;
        }

        public Region CreateRegion(string RegionName)
        {
            Region region = new Region();
            region.Id = Guid.NewGuid().ToString();
            region.RegionName = RegionName;

            _platformDbContext.Regions.Add(region);
            _platformDbContext.SaveChanges();

            return region;
        }

        public Region GetRegionById(string id)
        {
            return _platformDbContext.Regions.Where(e => e.Id == id).FirstOrDefault();
        }

        public void UpdateRegion(string id,string regionName)
        {
            Region region = GetRegionById(id);
            region.RegionName = regionName;
            _platformDbContext.Regions.Update(region);
            _platformDbContext.SaveChanges();
        }

        public void DeleteRegion(string id)
        {
            Region region = GetRegionById(id);
            _platformDbContext.Regions.Remove(region);
            _platformDbContext.SaveChanges();
        }

        public static implicit operator RegionService(TownService v)
        {
            throw new NotImplementedException();
        }
    } 
}
