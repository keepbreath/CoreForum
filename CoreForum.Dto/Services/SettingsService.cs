﻿using CoreForum.Dto.Constants;
using CoreForum.Dto.Interfaces;
using CoreForum.Dto.Interfaces.Services;
using CoreForum.Dto.Models.Entities;
using CoreForum.Dto.Models.Enums;
using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace CoreForum.Dto.Services
{
    public partial class SettingsService : ISettingsService
    {
        private ICoreForumContext _context;
        private readonly ICacheService _cacheService;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="context"> </param>
        /// <param name="cacheService"></param>
        public SettingsService(ICoreForumContext context, ICacheService cacheService)
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

        /// <summary>
        /// Get the site settings from cache, if not in cache gets from database and adds into the cache
        /// </summary>
        /// <returns></returns>
        public Settings GetSettings(bool useCache = true)
        {
            if (useCache)
            {
                var cachedSettings = _cacheService.Get<Settings>(CacheKeys.Settings.Main);
                if (cachedSettings == null)
                {
                    cachedSettings = GetSettingsLocal(false);
                    _cacheService.Set(CacheKeys.Settings.Main, cachedSettings, CacheTimes.OneDay);
                }
                return cachedSettings;
            }
            return GetSettingsLocal(true);
        }

        private Settings GetSettingsLocal(bool addTracking)
        {
            var settings = _context.Setting
                              .Include(x => x.DefaultLanguage)
                              .Include(x => x.NewMemberStartingRole);

            return addTracking ? settings.FirstOrDefault() : settings.AsNoTracking().FirstOrDefault();
        }

        public Settings Add(Settings settings)
        {
            return _context.Setting.Add(settings);
        }

        public Settings Get(Guid id)
        {
            return _context.Setting.FirstOrDefault(x => x.Id == id);
        }
    }
}
