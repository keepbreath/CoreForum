using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Events
{
    public class UpdateProfileEventArgs : CoreForumEventArgs
    {
        public MembershipUser User { get; set; }
    }
}
