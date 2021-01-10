using PlatformForJobSeeking.Database;
using System;

namespace PlatformForJobSeeking.Controllers
{
    internal class UserService
    {
        private PlatformDbContext platformDbContext;

        public UserService(PlatformDbContext platformDbContext)
        {
            this.platformDbContext = platformDbContext;
        }

        internal object GetUserById(string id)
        {
            throw new NotImplementedException();
        }

        internal void UpdateUser(string id, object userName)
        {
            throw new NotImplementedException();
        }

        internal void DeleteUser(string id)
        {
            throw new NotImplementedException();
        }

        internal object CreateUser(object userName)
        {
            throw new NotImplementedException();
        }
    }
}