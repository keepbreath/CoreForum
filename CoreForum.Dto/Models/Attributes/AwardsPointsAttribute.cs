using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class AwardsPointsAttribute : Attribute
    {
        public int Points { get; set; }

        public AwardsPointsAttribute(int points)
        {
            Points = points;
        }
    }
}
