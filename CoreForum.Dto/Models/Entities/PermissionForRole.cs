using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class PermissionForRole
    {
        public Permission Permission { get; set; }
        public MembershipRole MembershipRole { get; set; }
        public Category Category { get; set; }
        public bool IsTicked { get; set; }
    }
}
