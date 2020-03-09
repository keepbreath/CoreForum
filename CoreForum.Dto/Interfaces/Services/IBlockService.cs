using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IBlockService : IContextService
    {
        Block Add(Block block);
        void Delete(Block block);
        Block Get(Guid id);
    }
}
