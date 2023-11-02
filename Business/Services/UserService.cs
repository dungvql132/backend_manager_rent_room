using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using Data.Enum;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class UserService : Service<UserDTO, User>, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IDataRepository<User> dataRepository, IMapper mapper, IUserRepository userRepository) : base(dataRepository, mapper)
        {
            _userRepository = userRepository;
        }

        public async Task<List<UserDTO>> GetAllAsync(string email)
        {    
            var users = await this.GetAllAsync();
            return users.Where(x => x.Role == Role.Landlord || x.Email == email).ToList();
        }

        public async Task<List<UserDTO>> GetAllAsync(FilterUserDTO filterUserDTO)
        {
            var users = await _userRepository.GetAll(filterUserDTO);
            return _mapper.Map<List<UserDTO>>(users);
        }

        public async Task<UserDTO> GetAsync(Guid id, string email)
        {
            var user = await this.GetAsync(id);
            if(user.Role == Role.Admin) throw new Exception("you cannot get the admin data!");
            if(user.Role == Role.Staff && user.Email != email) throw new Exception("you cannot get data from another staff");
            return user;
        }
    }
}
