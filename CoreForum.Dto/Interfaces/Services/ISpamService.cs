using CoreForum.Dto.Models.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces.Services
{
    public partial interface ISpamService : IContextService
    {
        bool IsSpam(Post post);
        bool IsSpam(Topic topic);
        bool IsSpam(string content);
    }
}
