using CoreForum.Dto.Models.Entities;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.General
{
    public partial class UploadedFile
    {
        public UploadedFile()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public string Filename { get; set; }
        public virtual MembershipUser MembershipUser { get; set; }
        public virtual Post Post { get; set; }
        public DateTime DateCreated { get; set; }
        public string FilePath => $"{ForumConfiguration.Instance.UploadFolderPath}{MembershipUser.Id}/{Filename}";
    }
}
