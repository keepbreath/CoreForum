using CoreForum.Dto.Interfaces;
using CoreForum.Dto.Interfaces.Services;
using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreForum.Dto.Services
{
    public partial class BlockService : IBlockService
    {
        private ICoreForumContext _context;
        private readonly ICacheService _cacheService;

        public BlockService(ICoreForumContext context, ICacheService cacheService)
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

        public Block Add(Block block)
        {
            block.Date = DateTime.UtcNow;
            return _context.Block.Add(block);
        }

        public void Delete(Block block)
        {
            _context.Block.Remove(block);
        }

        public Block Get(Guid id)
        {
            return _context.Block.Find(id);
        }
    }
}
