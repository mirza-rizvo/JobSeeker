using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Request.Town;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class TownService
    {
        PlatformDbContext platformDbContext;
        public TownService(PlatformDbContext _platformDbContext) 
        {
            platformDbContext = _platformDbContext;
        }
        public Town CreateTown(CreateTown createTown)
        {
            Town town = new Town();
            town.Id = Guid.NewGuid().ToString();
            town.TownName = createTown.TownName;
            town.RegionId = createTown.RegionId;
            platformDbContext.Towns.Add(town);
            platformDbContext.SaveChanges();
            return town;
        }

        public Town GetTownById(string id)
        {
            return platformDbContext.Towns.Where(m => m.Id == id).FirstOrDefault();
        }

        public Town GetTown(string id)
        {
            return platformDbContext.Towns.Where(e => e.Id == id).FirstOrDefault();
        }

        public void UpdateTown(string id, string townName)
        {
            Town town = GetTown(id);
            town.TownName = townName;
            platformDbContext.Towns.Update(town);
            platformDbContext.SaveChanges();
        }
        public void DeleteTown(string id)
        {
            Town town = GetTown(id);
            platformDbContext.Towns.Remove(town);
            platformDbContext.SaveChanges();
        }
    }
}
