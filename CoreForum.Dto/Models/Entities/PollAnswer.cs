using CoreForum.Dto.Interfaces;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class PollAnswer : ExtendedDataEntity, IBaseEntity
    {
        public PollAnswer()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public string Answer { get; set; }
        public virtual Poll Poll { get; set; }
        public virtual IList<PollVote> PollVotes { get; set; }
    }
}
