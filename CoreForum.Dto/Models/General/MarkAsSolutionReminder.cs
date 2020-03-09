using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.General
{
    public class MarkAsSolutionReminder
    {
        public Topic Topic { get; set; }
        public int PostCount { get; set; }
    }
}
