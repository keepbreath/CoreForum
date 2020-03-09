using CoreForum.Dto.Models.Entities;
using System.Data.Entity.ModelConfiguration;
namespace CoreForum.Core.Data.Mapping
{
    public class CategoryNotificationMapping : EntityTypeConfiguration<CategoryNotification>
    {
        public CategoryNotificationMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();

            HasRequired(x => x.Category)
                .WithMany(x => x.CategoryNotifications)
                .Map(x => x.MapKey("Category_Id"))
                .WillCascadeOnDelete(false);

        }
    }
}
