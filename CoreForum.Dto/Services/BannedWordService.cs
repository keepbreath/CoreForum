using CoreForum.Dto.Interfaces;
using CoreForum.Dto.Interfaces.Services;
using CoreForum.Dto.Models.Entities;
using CoreForum.Dto.Models.General;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreForum.Dto.Services
{
    public partial class BannedWordService : IBannedWordService
    {
        private ICoreForumContext _context;
        private readonly ICacheService _cacheService;

        public BannedWordService(ICoreForumContext context, ICacheService cacheService)
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

        public BannedWord Add(BannedWord bannedWord)
        {
            return _context.BannedWord.Add(bannedWord);
        }

        public void Delete(BannedWord bannedWord)
        {
            _context.BannedWord.Remove(bannedWord);
        }

        public IList<BannedWord> GetAll(bool onlyStopWords = false)
        {

            if (onlyStopWords)
            {
                return _context.BannedWord.AsNoTracking().Where(x => x.IsStopWord == true).OrderByDescending(x => x.DateAdded).ToList();
            }
            return _context.BannedWord.AsNoTracking().Where(x => x.IsStopWord != true).OrderByDescending(x => x.DateAdded).ToList();

        }

        public BannedWord Get(Guid id)
        {
            return _context.BannedWord.Find(id);
        }

        public async Task<PaginatedList<BannedWord>> GetAllPaged(int pageIndex, int pageSize)
        {
            var query = _context.BannedWord.OrderBy(x => x.Word);
            return await PaginatedList<BannedWord>.CreateAsync(query.AsNoTracking(), pageIndex, pageSize);
        }

        public async Task<PaginatedList<BannedWord>> GetAllPaged(string search, int pageIndex, int pageSize)
        {
            search = StringUtils.SafePlainText(search);
            var query = _context.BannedWord
                            .Where(x => x.Word.ToLower().Contains(search.ToLower()))
                            .OrderBy(x => x.Word);
            return await PaginatedList<BannedWord>.CreateAsync(query.AsNoTracking(), pageIndex, pageSize);

        }

        public string SanitiseBannedWords(string content)
        {
            var bannedWords = GetAll();
            if (bannedWords.Any())
            {
                return SanitiseBannedWords(content, bannedWords.Select(x => x.Word).ToList());
            }
            return content;
        }

        public string SanitiseBannedWords(string content, IList<string> words)
        {
            if (words != null && words.Any() && !string.IsNullOrWhiteSpace(content))
            {
                var censor = new CensorUtils(words);
                return censor.CensorText(content);
            }
            return content;
        }

        /// <inheritdoc />
        public bool ContainsStopWords(string content, IList<string> words)
        {
            if (words != null && words.Any() && !string.IsNullOrWhiteSpace(content))
            {
                foreach (var word in words)
                {
                    if (content.ContainsCaseInsensitive(word))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
