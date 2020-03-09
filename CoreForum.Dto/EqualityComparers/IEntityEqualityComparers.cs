using CoreForum.Dto.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace CoreForum.Dto.EqualityComparers
{
    public class EntityEqualityComparer<T> : IEqualityComparer<T> where T : IBaseEntity
    {
        /// <inheritdoc />
        public bool Equals(T x, T y)
        {
            return y != null && (x != null && x.Id == y.Id);
        }

        /// <inheritdoc />
        public int GetHashCode(T obj)
        {
            return obj.Id.GetHashCode();
        }
    }
}
