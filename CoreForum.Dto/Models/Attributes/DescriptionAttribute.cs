using CoreForum.Dto.Interfaces.Services;
using CoreForum.Dto.Ioc;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DescriptionAttribute : Attribute
    {
        private readonly ILocalizationService _localizationService;

        public DescriptionAttribute(string desc)
        {
            if (_localizationService == null)
            {
                _localizationService = UnityHelper.Container.Resolve<ILocalizationService>();
            }

            Description = _localizationService.GetResourceString(desc.Trim());
        }

        public string Description { get; set; }
    }
}
