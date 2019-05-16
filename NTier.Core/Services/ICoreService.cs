using NTier.Core.Entities;
using System.Collections.Generic;

namespace NTier.Core.Services
{
    public interface ICoreService<T> where T : CoreEntity
    {
        void Add(T item);
        ICollection<T> GetAll();
    }
}
