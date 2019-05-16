using NTier.Core.Entities;
using NTier.Core.Services;
using System.Collections.Generic;

namespace NTier.Services.Service
{
    public class BaseService<T> : ICoreService<T> where T : CoreEntity
    {
        public void Add(T item)
        {

        }

        public ICollection<T> GetAll()
        {
            return null;
        }
    }
}
