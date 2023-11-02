using DataLayer.Database;
using DataLayer.Filter;
using DataLayer.Interfaces;
using DataLayer.Models;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Repositories
{
    public class HouseRepository : DataRepository<House>, IHouseRepository
    {
        public HouseRepository(MorkContext morkContext)
            : base(morkContext) { }

        public async Task<List<House>> GetAll(FilterHouse filterHouse)
        {
            var houses = _dbset
                        .Include(h => h.Address)
                        .Include(h => h.LandLordUser)
                        .Include(h => h.Campus)
                        .AsQueryable();
            if (filterHouse.CampusId != null)
            {
                houses = houses.Where(x => x.CampusId == filterHouse.CampusId);
            }
            if (filterHouse.MaxWaterPrice != null)
            {
                houses = houses.Where(x => x.WaterPrice <= filterHouse.MaxWaterPrice);
            }
            if (filterHouse.MaxPowerPrice != null)
            {
                houses = houses.Where(x => x.PowerPrice <= filterHouse.MaxPowerPrice);
            }
            if (filterHouse.LandLordId != null)
            {
                houses = houses.Where(x => x.LandLordId == filterHouse.LandLordId);
            }
            if (!string.IsNullOrEmpty(filterHouse.HouseName))
            {
                houses = houses.Where(x => x.HouseName.Contains(filterHouse.HouseName));
            }
            return await houses.ToListAsync();
        }
    }
}
