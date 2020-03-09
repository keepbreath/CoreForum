using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IFavouriteService : IContextService
    {
        Favourite Add(Favourite dialogueFavourite);
        Favourite Delete(Favourite dialogueFavourite);
        List<Favourite> GetAll();
        Favourite Get(Guid id);
        List<Favourite> GetAllByMember(Guid memberId);
        Favourite GetByMemberAndPost(Guid memberId, Guid postId);
        List<Favourite> GetByTopic(Guid topicId);
        Dictionary<Guid, List<Favourite>> GetByTopicGroupedByPost(Guid topicId);
        Dictionary<Guid, Dictionary<Guid, List<Favourite>>> GetByTopicsGroupedIntoPosts(List<Guid> topicIds);
        Dictionary<Guid, List<Favourite>> GetAllPostFavourites(List<Guid> postIds);
    }
}
