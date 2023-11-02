using DataLayer.Database;
using DataLayer.Filter;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class UserRepository : DataRepository<User>, IUserRepository
    {
        public UserRepository(MorkContext morkContext)
            : base(morkContext) { }

        public async Task<User> Find(string email)
        {
            return await _dbset.FirstOrDefaultAsync((s => s.Email == email));
        }

        public async Task<User> Find(string email, string password)
        {
            return await _dbset.FirstOrDefaultAsync(
                (s => s.Email == email && s.Password == password)
            );
        }

        public async Task<List<User>> GetAll(FilterUser filterUser)
        {
            var users = _dbset.AsQueryable();
            if(filterUser.DisplayName != null){
                users = users.Where(x => x.DisplayName.Contains(filterUser.DisplayName));
            }
            return await users.ToListAsync();
        }
    }
}
