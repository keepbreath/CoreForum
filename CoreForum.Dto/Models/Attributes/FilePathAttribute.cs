using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class FilePathAttribute : Attribute
    {
        public FilePathAttribute(string filePath)
        {
            FilePath = filePath;
        }

        public string FilePath { get; set; }
    }
}
