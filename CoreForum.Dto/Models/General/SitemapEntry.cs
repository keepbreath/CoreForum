using CoreForum.Dto.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.General
{
    public class SitemapEntry
    {
        public string Name { get; set; }
        public string Url { get; set; }
        public DateTime LastUpdated { get; set; }
        public SiteMapChangeFreqency ChangeFrequency { get; set; }
        public string Priority { get; set; }
    }
}
