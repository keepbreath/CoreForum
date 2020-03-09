using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.General
{
    public class FileCheckResult
    {
        public bool IsOk { get; set; }
        public string FileName { get; set; }
        public string FileExtension { get; set; }
        public string Message { get; set; }
        public bool IsImage { get; set; }
    }
}
