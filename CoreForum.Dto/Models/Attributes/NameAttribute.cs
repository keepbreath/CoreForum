using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class NameAttribute : Attribute
    {
        public NameAttribute(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}
