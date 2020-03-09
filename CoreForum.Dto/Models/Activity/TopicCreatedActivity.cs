using CoreForum.Dto.Models.Entities;
using CoreForum.Dto.Models.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Models.Activity
{
    public class TopicCreatedActivity : ActivityBase
    {
        public Topic Topic { get; set; }

        public TopicCreatedActivity(Activity activity, Topic topic)
        {
            ActivityMapped = activity;
            Topic = topic;
        }

        public static Activity GenerateMappedRecord(Topic topic, DateTime timestamp)
        {
            return new Activity
            {
                Data = topic.Id.ToString(),
                Timestamp = timestamp,
                Type = ActivityType.TopicCreated.ToString()
            };

        }
    }
}
