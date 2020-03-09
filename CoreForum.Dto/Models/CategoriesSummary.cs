using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models
{
    /// <summary>
    /// Used when listing Categories
    /// </summary>
    public class CategorySummary
    {
        public Category Category { get; set; }
        public int TopicCount { get; set; }
        public int PostCount { get; set; }
        public Topic MostRecentTopic { get; set; }
    }
}
