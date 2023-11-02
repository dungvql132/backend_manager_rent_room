using DataLayer.Database;
using DataLayer.Filter;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class RoomRepository : DataRepository<Room>, IRoomRepository
    {
        public RoomRepository(MorkContext morkContext)
            : base(morkContext) { }

        public async Task<List<Room>> GetAll(FilterRoom filterRoom)
        {
            var rooms = _dbset
                        .AsQueryable();
            if (!string.IsNullOrEmpty(filterRoom.RoomName))
            {
                rooms = rooms.Where(x => x.RoomName.Contains(filterRoom.RoomName));
            }
            if (filterRoom.Type != null)
            {
                rooms = rooms.Where(x => x.Type == filterRoom.Type);
            }
            return await rooms.ToListAsync();
        }

        public async override Task<Room> Get(Guid? id)
        {
            var rooms = _dbset.Include(h => h.House).Include(h => h.House.LandLordUser).AsQueryable();
            return await rooms.FirstOrDefaultAsync();
        }
    }
}
