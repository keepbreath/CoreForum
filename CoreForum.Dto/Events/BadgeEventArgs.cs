using CoreForum.Dto.Models.Entities;
using CoreForum.Dto.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Events
{
    public class BadgeEventArgs : CoreForumEventArgs
    {
        public MembershipUser User { get; set; }
        public BadgeType BadgeType { get; set; }
    }
}
