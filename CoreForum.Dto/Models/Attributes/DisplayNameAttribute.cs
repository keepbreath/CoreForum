using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Attributes
{
    [AttributeUsage(AttributeTargets.Class)]
    public class DisplayNameAttribute : Attribute
    {
        private readonly ILocalizationService _localizationService;

        public DisplayNameAttribute(string desc)
        {
            if (_localizationService == null)
            {
                _localizationService = UnityHelper.Container.Resolve<ILocalizationService>();
            }
            DisplayName = _localizationService.GetResourceString(desc.Trim());
        }

        public string DisplayName { get; set; }
    }
}
