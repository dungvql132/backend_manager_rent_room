using DataLayer.Filter;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IUserRepository: IDataRepository<User>
    {
        Task<User> Find(string email);
        Task<User> Find(string email, string password);
        Task<List<User>> GetAll(FilterUser filterUser);
    }
}
