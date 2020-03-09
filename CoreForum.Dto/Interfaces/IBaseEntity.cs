using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.Interfaces
{
    /// <summary>
    /// 标识GUID
    /// </summary>
    public interface IBaseEntity
    {
        Guid Id { get; set; }
    }
}
