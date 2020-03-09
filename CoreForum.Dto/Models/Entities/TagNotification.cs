using CoreForum.Dto.Interfaces;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class TagNotification : IBaseEntity
    {
        public TagNotification()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public virtual TopicTag Tag { get; set; }
        public virtual MembershipUser User { get; set; }
    }
}
