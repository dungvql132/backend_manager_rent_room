using DataLayer.Filter;
using DataLayer.Models;

namespace DataLayer.Interfaces
{
    public interface IRoomRepository: IDataRepository<Room>
    {
        Task<List<Room>> GetAll(FilterRoom filterRoom);
    }
}
