using CoreForum.Dto.Interfaces;
using CoreForum.Utils;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public partial class BannedWord : IBaseEntity
    {
        public BannedWord()
        {
            Id = GuidComb.GenerateComb();
        }
        public Guid Id { get; set; }
        public string Word { get; set; }
        public bool? IsStopWord { get; set; }
        public DateTime DateAdded { get; set; }
    }
}
