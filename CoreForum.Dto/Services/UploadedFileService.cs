using CoreForum.Dto.Interfaces;
using CoreForum.Dto.Interfaces.Services;
using CoreForum.Dto.Models.General;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreForum.Dto.Services
{
    public partial class UploadedFileService : IUploadedFileService
    {
        private ICoreForumContext _context;

        public UploadedFileService(ICoreForumContext context)
        {
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

        public UploadedFile Add(UploadedFile uploadedFile)
        {
            uploadedFile.DateCreated = DateTime.UtcNow;
            return _context.UploadedFile.Add(uploadedFile);
        }

        public void Delete(UploadedFile uploadedFile)
        {
            _context.UploadedFile.Remove(uploadedFile);
        }

        public IList<UploadedFile> GetAll()
        {
            return _context.UploadedFile.ToList();
        }

        public IList<UploadedFile> GetAllByPost(Guid postId)
        {
            return _context.UploadedFile.Where(x => x.Post.Id == postId).ToList();
        }

        public IList<UploadedFile> GetAllByUser(Guid membershipUserId)
        {
            return _context.UploadedFile.Where(x => x.MembershipUser.Id == membershipUserId).ToList();
        }

        public UploadedFile Get(Guid id)
        {
            return _context.UploadedFile
                .Include(x => x.Post.Topic.Category)
                .FirstOrDefault(x => x.Id == id);
        }
    }
}
