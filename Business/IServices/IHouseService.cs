using BusinessLayer.DTOs;
using DataLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IHouseService : IService<HouseDTO,House>
    {
        public Task<List<HouseDTO>> GetAllAsync(FilterHouseDTO filterHouseDTO);
        public Task UpdateAsync(HouseUpdateDTO houseUpdateDTO, Guid id, string email);
    }
}
