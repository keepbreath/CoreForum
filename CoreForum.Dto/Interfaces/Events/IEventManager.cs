using CoreForum.Dto.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace CoreForum.Dto.Interfaces.Events
{
    public partial interface IEventManager
    {
        /// <summary>
        ///     Use reflection to get all event handling classes. Call this ONCE.
        /// </summary>
        void Initialize(ILoggingService loggingService, List<Assembly> assemblies);
    }
}
