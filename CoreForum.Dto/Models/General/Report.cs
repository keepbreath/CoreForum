using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.General
{
    public partial class Report
    {
        public string Reason { get; set; }
        public virtual MembershipUser Reporter { get; set; }
        public virtual MembershipUser ReportedMember { get; set; }
        public virtual Post ReportedPost { get; set; }
    }
}
