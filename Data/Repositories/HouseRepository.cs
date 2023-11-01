using DataLayer.Database;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class HouseRepository : DataRepository<House>, IHouseRepository
    {
        public HouseRepository(MorkContext morkContext)
            : base(morkContext) { }

    }
}
