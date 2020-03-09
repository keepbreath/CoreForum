using CoreForum.Dto.Interfaces;
using CoreForum.Dto.Models.Enums;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class MembershipUserPoints : IBaseEntity
    {
        public MembershipUserPoints()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public int Points { get; set; }
        public DateTime DateAdded { get; set; }
        public PointsFor PointsFor { get; set; }
        public Guid? PointsForId { get; set; }
        public string Notes { get; set; }
        public virtual MembershipUser User { get; set; }
    }
}
