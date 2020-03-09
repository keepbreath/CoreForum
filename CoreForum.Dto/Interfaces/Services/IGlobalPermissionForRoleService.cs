using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IGlobalPermissionForRoleService : IContextService
    {
        GlobalPermissionForRole Add(GlobalPermissionForRole permissionForRole);
        void Delete(GlobalPermissionForRole permissionForRole);
        GlobalPermissionForRole CheckExists(GlobalPermissionForRole permissionForRole);
        Dictionary<Permission, GlobalPermissionForRole> GetAll(MembershipRole role);
        Dictionary<Permission, GlobalPermissionForRole> GetAll();
        GlobalPermissionForRole Get(Guid permId, Guid roleId);
        GlobalPermissionForRole Get(Guid permId);
        void UpdateOrCreateNew(GlobalPermissionForRole globalPermissionForRole);
    }
}
