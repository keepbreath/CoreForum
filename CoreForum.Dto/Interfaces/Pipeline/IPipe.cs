using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CoreForum.Dto.Interfaces.Pipeline
{
    public interface IPipe<T>
    {
        Task<T> Process(T input, ICoreForumContext context);
    }
}
