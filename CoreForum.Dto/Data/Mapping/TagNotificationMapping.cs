using CoreForum.Dto.Models.Entities;
using System.Data.Entity.ModelConfiguration;
namespace CoreForum.Core.Data.Mapping
{
    public class TagNotificationMapping : EntityTypeConfiguration<TagNotification>
    {
        public TagNotificationMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();

            HasRequired(x => x.Tag)
                .WithMany(x => x.Notifications)
                .Map(x => x.MapKey("TopicTag_Id"))
                .WillCascadeOnDelete(false);
        }
    }
}
