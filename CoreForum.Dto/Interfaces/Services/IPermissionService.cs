using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IPermissionService : IContextService
    {
        IEnumerable<Permission> GetAll();
        Permission Add(Permission permission);
        void Delete(Permission permission);
        Permission Get(Guid id);
    }
}
