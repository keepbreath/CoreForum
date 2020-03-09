using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class ImageAttribute : Attribute
    {
        public ImageAttribute(string name)
        {
            Image = name;
        }

        public string Image { get; set; }
    }
}
