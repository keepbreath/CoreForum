using CoreForum.Dto.Interfaces;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class PostEdit : IBaseEntity
    {
        public PostEdit()
        {
            Id = GuidComb.GenerateComb();
        }

        public Guid Id { get; set; }
        public DateTime DateEdited { get; set; }
        public string OriginalPostContent { get; set; }
        public string EditedPostContent { get; set; }
        public string OriginalPostTitle { get; set; }
        public string EditedPostTitle { get; set; }
        public virtual MembershipUser EditedBy { get; set; }
        public virtual Post Post { get; set; }
    }
}
