using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class PollVote
    {
        public PollVote()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public virtual PollAnswer PollAnswer { get; set; }
        public virtual MembershipUser User { get; set; }
    }
}
