using DataLayer.Database;
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
    }
}
