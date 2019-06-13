using AWSAPP.DataAccess.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AWSAPP.DataAccess.Repositories
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : class
    {
        protected readonly DataBaseContextConfiguration _context;

        protected DbSet<TEntity> _dbSet;

        public BaseRepository(DataBaseContextConfiguration context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public Task<int> Create(TEntity item)
        {
            _dbSet.Add(item);
            return _context.SaveChangesAsync();
        }

        public async Task<int> CreateRange(IEnumerable<TEntity> items)
        {
            _dbSet.AddRange(items);
            return await _context.SaveChangesAsync();
        }

        public Task<TEntity> FindById(long id)
        { 
            try
            {
                return _dbSet.FindAsync(id);
            }
            catch
            {
                return null;
            }
            
        }

        public Task<List<TEntity>> Get()
        {
            return _dbSet.AsNoTracking().ToListAsync();
        }

        public List<TEntity> Get(Func<TEntity, bool> predicate)
        {
            return _dbSet.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<long> GetCount()
        {
            return await _dbSet.LongCountAsync();
        }

        public Task<int> Remove(TEntity item)
        {
            _dbSet.Remove(item);
            return _context.SaveChangesAsync();
        }

        public Task<int> Update(TEntity item)
        {
            _context.Entry(item).State = EntityState.Modified;
            return _context.SaveChangesAsync();
        }

        public async Task<int> UpdateRange(IEnumerable<TEntity> entities)
        {
            _dbSet.UpdateRange(entities);
            return await _context.SaveChangesAsync();
        }
    }
}
