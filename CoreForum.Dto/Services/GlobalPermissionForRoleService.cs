using CoreForum.Dto.Interfaces;
using CoreForum.Dto.Interfaces.Services;
using CoreForum.Dto.Models.Entities;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CoreForum.Dto.Services
{
    public partial class GlobalPermissionForRoleService : IGlobalPermissionForRoleService
    {
        private ICoreForumContext _context;
        private readonly ICacheService _cacheService;

        public GlobalPermissionForRoleService(ICoreForumContext context, ICacheService cacheService)
        {
            _cacheService = cacheService;
            _context = context;
        }

        /// <inheritdoc />
        public void RefreshContext(ICoreForumContext context)
        {
            _context = context;
        }

        /// <inheritdoc />
        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        public GlobalPermissionForRole Add(GlobalPermissionForRole permissionForRole)
        {
            return _context.GlobalPermissionForRole.Add(permissionForRole);
        }

        public void Delete(GlobalPermissionForRole permissionForRole)
        {
            _context.GlobalPermissionForRole.Remove(permissionForRole);
        }

        public GlobalPermissionForRole CheckExists(GlobalPermissionForRole permissionForRole)
        {
            if (permissionForRole.Permission != null && permissionForRole.MembershipRole != null)
            {
                return Get(permissionForRole.Permission.Id, permissionForRole.MembershipRole.Id);
            }

            return null;
        }

        public Dictionary<Permission, GlobalPermissionForRole> GetAll(MembershipRole role)
        {

            var catRowList = _context.GlobalPermissionForRole.AsNoTracking().Include(x => x.MembershipRole).Where(x => x.MembershipRole.Id == role.Id).ToList();
            return catRowList.ToDictionary(catRow => catRow.Permission);

        }

        public Dictionary<Permission, GlobalPermissionForRole> GetAll()
        {
            var catRowList = _context.GlobalPermissionForRole.AsNoTracking().Include(x => x.MembershipRole).ToList();
            return catRowList.ToDictionary(catRow => catRow.Permission);
        }

        public GlobalPermissionForRole Get(Guid permId, Guid roleId)
        {
            return _context.GlobalPermissionForRole
                                                                            .Include(x => x.MembershipRole)
                                                                            .FirstOrDefault(x => x.Permission.Id == permId && x.MembershipRole.Id == roleId);
        }

        public GlobalPermissionForRole Get(Guid permId)
        {
            return _context.GlobalPermissionForRole
                                                                             .Include(x => x.MembershipRole)
                                                                             .FirstOrDefault(x => x.Id == permId);
        }

        public void UpdateOrCreateNew(GlobalPermissionForRole globalPermissionForRole)
        {
            // Firstly see if this exists already
            var permission = CheckExists(globalPermissionForRole);

            // if it exists then just update it
            if (permission != null)
            {
                permission.IsTicked = globalPermissionForRole.IsTicked;
            }
            else
            {
                Add(globalPermissionForRole);
            }
        }
    }
}
