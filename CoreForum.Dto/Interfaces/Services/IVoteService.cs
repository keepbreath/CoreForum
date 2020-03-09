using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface IVoteService : IContextService
    {
        Vote Add(Vote vote);
        Vote Get(Guid id);
        void Delete(Vote vote);
        IList<Vote> GetAllVotesByUser(Guid membershipId);
        Dictionary<Guid, List<Vote>> GetVotesByPosts(List<Guid> postIds);
        Dictionary<Guid, Dictionary<Guid, List<Vote>>> GetVotesByTopicsGroupedIntoPosts(List<Guid> topicIds);
        List<Vote> GetVotesByPost(Guid postId);
    }
}
