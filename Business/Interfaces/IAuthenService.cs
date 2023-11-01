using BusinessLayer.DTOs;
using BusinessLayer.Services;
using DataLayer.Models;

namespace BusinessLayer.Interfaces
{
    public interface IAuthenService
    {
        public Task<LoginResponseUserDTO> Login(LoginUserDTO loginUserDTO);
        public Task<UserDTO> Register(RegisterUserDTO registerUserDTO);
    }
}
