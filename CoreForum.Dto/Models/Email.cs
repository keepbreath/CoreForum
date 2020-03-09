using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models
{
    public partial class Email
    {
        public string NameTo { get; set; }
        public string EmailTo { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
    }
}
