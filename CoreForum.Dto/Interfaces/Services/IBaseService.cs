﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IContextService
    {
        /// <summary>
        ///     When using pipelines, we need to make sure we are using the same context throughout, or we'll end up with an error
        ///     like
        ///     'An entity object cannot be referenced by multiple instances of IEntityChangeTracker'. So we pass in the existing
        ///     context
        ///     and it replaces the one created by the IoC provider
        /// </summary>
        /// <param name="context"></param>
        void RefreshContext(ICoreForumContext context);
        Task<int> SaveChanges();
    }
}
