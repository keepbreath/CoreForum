using CoreForum.Dto.Interfaces;
using CoreForum.Dto.Interfaces.Services;
using CoreForum.Dto.Models.Entities;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreForum.Dto.Services
{
    public partial class PermissionService : IPermissionService
    {
        private ICoreForumContext _context;
        private readonly ICategoryPermissionForRoleService _categoryPermissionForRoleService;
        private readonly ICacheService _cacheService;

        public PermissionService(ICategoryPermissionForRoleService categoryPermissionForRoleService, ICoreForumContext context, ICacheService cacheService)
        {
            _categoryPermissionForRoleService = categoryPermissionForRoleService;
            _cacheService = cacheService;
            _context = context;
        }

        /// <inheritdoc />
        public void RefreshContext(ICoreForumContext context)
        {
            _context = context;
            _categoryPermissionForRoleService.RefreshContext(context);
        }

        /// <inheritdoc />
        public async Task<int> SaveChanges()
        {
            return await _context.SaveChangesAsync();
        }

        /// <summary>
        /// Get all permissions
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Permission> GetAll()
        {
            // Request Cache these as it gets called quite a lot
            var allPermissions = HttpContext.Current.Items["AllPermissions"];
            if (allPermissions == null)
            {
                HttpContext.Current.Items["AllPermissions"] = _context.Permission
                    .AsNoTracking()
                    .OrderBy(x => x.Name)
                    .ToList();
            }
            return (IEnumerable<Permission>)HttpContext.Current.Items["AllPermissions"];
        }

        /// <summary>
        /// Add a new permission
        /// </summary>
        /// <param name="permission"></param>
        public Permission Add(Permission permission)
        {
            permission.Name = StringUtils.SafePlainText(permission.Name);
            return _context.Permission.Add(permission);
        }

        /// <summary>
        ///  Delete permission and associated category permission for roles
        /// </summary>
        /// <param name="permission"></param>
        public void Delete(Permission permission)
        {
            var catPermForRoles = _categoryPermissionForRoleService.GetByPermission(permission.Id);
            foreach (var categoryPermissionForRole in catPermForRoles)
            {
                _categoryPermissionForRoleService.Delete(categoryPermissionForRole);
            }

            _context.Permission.Remove(permission);
        }

        /// <summary>
        /// Get a permision by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Permission Get(Guid id)
        {

            return _context.Permission.FirstOrDefault(x => x.Id == id);
        }
    }
}
