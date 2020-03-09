using CoreForum.Dto.Interfaces;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class Block : IBaseEntity
    {
        public Block()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public MembershipUser Blocker { get; set; }
        public MembershipUser Blocked { get; set; }
        public DateTime Date { get; set; }
    }
}
