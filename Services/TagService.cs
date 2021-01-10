using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using PlatformForJobSeeking.Request.Tag;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class TagService
    {
        PlatformDbContext platformDbContext;
        public TagService(PlatformDbContext _platformDbContext)
        {
            platformDbContext = _platformDbContext;
        }

        public Tag CreateTag(CreateTag createTag)
        {
            Tag tag = new Tag();
            tag.Id = Guid.NewGuid().ToString();
            tag.DateCreated = DateTime.Now;
            tag.DateModified = DateTime.Now;
            tag.TagName = createTag.TagName;

            platformDbContext.Tags.Add(tag);
            platformDbContext.SaveChanges();
            return tag;
        }

        internal object CreateTag(string tagName)
        {
            throw new NotImplementedException();
        }

        internal object GetTagById(string id)
        {
            throw new NotImplementedException();
        }

        internal void TagRegion(string id, string tagName)
        {
            throw new NotImplementedException();
        }

        public Tag GetTag(string id)
        {
            return platformDbContext.Tags.Where(e => e.Id == id).FirstOrDefault();
        }

        public void UpdateTagById(string id, UpdateTag updateTag)
        {
            Tag tag = GetTag(id);
            tag.DateModified = DateTime.Now;
            tag.TagName = updateTag.TagName;
            platformDbContext.Tags.Update(tag);
            platformDbContext.SaveChanges();
        }

        public void DeleteTag(string id)
        {
            Tag tag = GetTag(id);
            platformDbContext.Tags.Remove(tag);
            platformDbContext.SaveChanges();
        }
    }
}
