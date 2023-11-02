using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class DataRepository<T> : IDataRepository<T>
        where T : BaseModel
    {
        protected readonly MorkContext _morkContext;
        protected DbSet<T> _dbset;

        public DataRepository(MorkContext morkContext)
        {
            _morkContext = morkContext;
            _dbset = _morkContext.Set<T>();
        }

        public virtual async Task Add(T entity)
        {
            _dbset.Add(entity);
            await _morkContext.SaveChangesAsync();
        }

        public virtual async Task Delete(T entity)
        {
            _dbset.Remove(entity);
            await _morkContext.SaveChangesAsync();
        }

        public virtual async Task Update(T entity)
        {
            _dbset.Update(entity);
            System.Console.WriteLine("String -------: "+entity.ToString());
            await _morkContext.SaveChangesAsync();       
        }

        public virtual async Task<T> Get(Guid? id)
        {
            return await _dbset.SingleOrDefaultAsync(s => s.Id == id);
        }

        public virtual async Task<List<T>> GetAll()
        {
            var entities = await _morkContext.Set<T>().ToListAsync();
            return entities;
        }

        public virtual async Task Save()
        {
            await _morkContext.SaveChangesAsync();
        }
    }
}
