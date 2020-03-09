using CoreForum.Dto.Models.Entities;
using System.Data.Entity.ModelConfiguration;
namespace CoreForum.Core.Data.Mapping
{
    public class TopicNotificationMapping : EntityTypeConfiguration<TopicNotification>
    {
        public TopicNotificationMapping()
        {
            HasKey(x => x.Id);
            Property(x => x.Id).IsRequired();
        }
    }
}
