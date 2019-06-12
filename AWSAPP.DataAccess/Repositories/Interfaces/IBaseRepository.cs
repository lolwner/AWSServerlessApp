using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AWSAPP.DataAccess.Repositories.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        Task<int> Create(TEntity item);
        Task<int> CreateRange(IEnumerable<TEntity> items);
        Task<TEntity> FindById(long id);
        Task<List<TEntity>> Get();
        List<TEntity> Get(Func<TEntity, bool> predicate);
        Task<long> GetCount();
        Task<int> Remove(TEntity item);
        Task<int> Update(TEntity item);
        Task<int> UpdateRange(IEnumerable<TEntity> entities);
    }
}
