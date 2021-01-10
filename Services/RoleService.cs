using PlatformForJobSeeking.Database;
using PlatformForJobSeeking.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlatformForJobSeeking.Services
{
    public class RoleService
    {
        PlatformDbContext _platformDbContext;
        public RoleService(PlatformDbContext platformDbContext)
        {
            this._platformDbContext = platformDbContext;
        }

        public Role CreateRole(string roleName)
        {
            Role role = new Role();
            role.Id = Guid.NewGuid().ToString();
            role.Name = roleName;
            _platformDbContext.Roles.Add(role);
            _platformDbContext.SaveChanges();

            return role;
        }

        public Role GetRoleById(string id)
        {
            throw new NotImplementedException();
        }

        public Role GetRole(string id)
        {
            return _platformDbContext.Roles.Where(e => e.Id == id).FirstOrDefault();
        }

        public void UpdateRole(string id, Role updateRole)
        {
            Role role = GetRole(updateRole.Id);
            role.Name = updateRole.Name;

            _platformDbContext.Roles.Update(role);
            _platformDbContext.SaveChanges();
        }

        internal void UpdateRole(string id, string roleName)
        {
            throw new NotImplementedException();
        }

        public void DeleteRole(string id)
        {
            Role role = GetRole(id);
            _platformDbContext.Roles.Remove(role);
        }
    }
}
