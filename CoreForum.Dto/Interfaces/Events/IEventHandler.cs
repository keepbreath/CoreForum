using CoreForum.Dto.Events;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Events
{
    public partial interface IEventHandler
    {
        void RegisterHandlers(EventManager theEventManager);
    }
}
