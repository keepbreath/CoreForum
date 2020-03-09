using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Events
{
    public class PostMadeEventArgs : CoreForumEventArgs
    {
        public Post Post { get; set; }
    }
}
