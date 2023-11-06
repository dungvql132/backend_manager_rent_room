using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IDataRepository<T> where T : BaseModel
    {
        Task<T> Get(Guid? id);
        Task<List<T>> GetAll();
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Save();
    }
}
