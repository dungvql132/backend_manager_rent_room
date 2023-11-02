using BusinessLayer.DTOs;
using DataLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IUserService : IService<UserDTO,User>
    {
        public Task<List<UserDTO>> GetAllAsync(string email);
        public Task<UserDTO> GetAsync(Guid id, string email);

        public Task<List<UserDTO>> GetAllAsync(FilterUserDTO filterUserDTO);
    }
}
