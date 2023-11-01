using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class UserService : Service<UserDTO, User>, IUserService
    {
        public UserService(IDataRepository<User> dataRepository, IMapper mapper) : base(dataRepository, mapper)
        {
        }
    }
}
