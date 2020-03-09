using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.General
{
    /// <summary>
    ///     This is a special domain model and not mapped to the database
    ///     its use to make an efficient call to get a category with subcategories and only
    ///     used for display purposes. This is due to the database structure and EF getting in a
    ///     mess when we try to map sub categories by doing a join on itself (Category table)
    /// </summary>
    public partial class CategoryWithSubCategories
    {
        public Category Category { get; set; }
        public IEnumerable<Category> SubCategories { get; set; }
    }
}
