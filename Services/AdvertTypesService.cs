using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Request.AdvertType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class AdvertTypesService
    {
        PlatformDbContext platformDbContext;

        public AdvertTypesService(PlatformDbContext _platformDbContext)
        {
            platformDbContext = _platformDbContext;
        }

        public AdvertType CreateAdvertType(CreateAdvertType createAdvertType)
        {
            AdvertType advertType = new AdvertType();
            advertType.Id = Guid.NewGuid().ToString();
            advertType.Description = createAdvertType.Description;
            advertType.AdvertTypeName = createAdvertType.AdvertTypeName;

            platformDbContext.AdvertTypes.Add(advertType);
            platformDbContext.SaveChanges();
            return advertType;
        }

        public AdvertType GetAdvertTypeById(string id)
        {
            AdvertType advertType = platformDbContext.AdvertTypes.Where(m => m.Id == id).FirstOrDefault();
            if(advertType == null)
            {
                throw new ArgumentException();
            }
            else
            {
                return advertType;
            }
        }

        public void UpdateAdvertType(string id, UpdateAdvertType updateAdvertType)
        {
            AdvertType advertType = GetAdvertTypeById(id);
            if (advertType == null)
            {
                throw new ArgumentException();
            }
            else
            {
                advertType.AdvertTypeName = updateAdvertType.AdvertTypeName;
                advertType.Description = updateAdvertType.Description;

                platformDbContext.AdvertTypes.Update(advertType);
                platformDbContext.SaveChanges();
            }
        }
        public void DeleteAdvertType(string id)
        {
            AdvertType advertType = GetAdvertTypeById(id);
            platformDbContext.AdvertTypes.Remove(advertType);
        }
    }
}
