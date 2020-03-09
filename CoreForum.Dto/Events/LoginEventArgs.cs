using CoreForum.Dto.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Events
{
    public class LoginEventArgs : CoreForumEventArgs
    {
        public string ReturnUrl { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }
        public ICoreForumContext CoreForumContext { get; set; }
    }
}
