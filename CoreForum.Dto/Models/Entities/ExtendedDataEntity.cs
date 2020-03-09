using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CoreForum.Dto.Models.Entities
{
    public class ExtendedDataEntity
    {
        /// <summary>
        /// The extended data backing field
        /// DO NOT USE, this is purely for storing serialised JSON
        /// </summary>

        public string ExtendedDataString { get; set; }

        /// <summary>
        /// The ExtentedData. You must use the extension methods to set, get and delete extended data
        /// SetExtendedDataValue, RemoveExtendedDataItem, GetExtendedDataItem
        /// </summary>
        [NotMapped]
        public List<ExtendedDataItem> ExtendedData
        {
            get
            {
                if (string.IsNullOrWhiteSpace(ExtendedDataString))
                {
                    return new List<ExtendedDataItem>();
                }
                return JsonConvert.DeserializeObject<List<ExtendedDataItem>>(ExtendedDataString);
            }
            set
            {
                if (value != null)
                {
                    ExtendedDataString = JsonConvert.SerializeObject(value, new JsonSerializerSettings { Formatting = Formatting.None });
                }
            }
        }
    }
}
