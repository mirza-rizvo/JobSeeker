using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Request;
using PlatformForJobSeeking.Request.Advert;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class AdvertService
    {
        PlatformDbContext platformDbContext;
        public AdvertService(PlatformDbContext _platformDbContext)
        {
            platformDbContext = _platformDbContext;
        }

        public Advert InsertAdvert(CreateAdvert createAdvert)
        {
            Advert advert = new Advert();
            advert.Id = Guid.NewGuid().ToString();
            advert.AdName = createAdvert.AdName;
            advert.AdDuration = createAdvert.AdDuration;
            advert.AdDescription = createAdvert.AdDescription;
            advert.DateCreated = DateTime.Now;
            advert.NumberOfSeekers = createAdvert.NumberOfSeekers;
            advert.TownId = createAdvert.TownId;
            advert.AdvertTypeId = createAdvert.AdvertTypeId;
            platformDbContext.Adverts.Add(advert);
            platformDbContext.SaveChanges();
            return advert;
        }

        public Advert GetAdvertById(string id)
        {
            return platformDbContext.Adverts.Where(m => m.Id == id).FirstOrDefault();
        }
        
        public void UpdateAdvertById(string id, UpdateAdvert updateAdvert)
        {
            Advert advert = GetAdvertById(id);
            if(advert == null)
            {
                throw new ArgumentException();
            }
            else
            {
                advert.AdDescription = updateAdvert.AdDescription;
                advert.AdDuration = updateAdvert.AdDuration;
                advert.AdName = updateAdvert.AdName;
                advert.NumberOfSeekers = updateAdvert.NumberOfSeekers;
            }

            platformDbContext.Adverts.Update(advert);
            platformDbContext.SaveChanges();
        }

        public void DeleteAdvertById(string id)
        {
            Advert advert = GetAdvertById(id);
            if (advert == null)
            {
                throw new ArgumentException();
            }
            else
            {
                platformDbContext.Adverts.Remove(advert);
                platformDbContext.SaveChanges();
            }
        }
    }
}
