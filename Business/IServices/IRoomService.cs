using BusinessLayer.DTOs;
using DataLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IRoomService : IService<RoomDTO, Room>
    {
        public Task<List<RoomDTO>> GetAllAsync(FilterRoomDTO filterRoomDTO);
        public Task UpdateAsync(RoomUpdateDTO RoomUpdateDTO, Guid id, string email);
        public Task<RoomDTO> AddAsync(RoomDTO item, string email);
        public Task DeleteAsync(Guid id, string email);
    }
}
