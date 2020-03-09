using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class IdAttribute : Attribute
    {
        public IdAttribute(string guid)
        {
            Id = new Guid(guid);
        }

        public Guid Id { get; set; }
    }
}
