using DataLayer.Filter;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IHouseRepository: IDataRepository<House>
    {
        Task<List<House>> GetAll(FilterHouse filterHouse);
    }
}
