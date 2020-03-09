using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Events
{
    public abstract class CoreForumEventArgs : EventArgs
    {
        public bool Cancel { get; set; }
    }
}
