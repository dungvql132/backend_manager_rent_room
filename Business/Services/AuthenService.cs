using AutoMapper;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using Data.Enum;
using DataLayer.Interfaces;
using DataLayer.Models;

namespace BusinessLayer.Services
{
    public class AuthenService : IAuthenService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        private readonly ITokenService _tokenService;

        public AuthenService(IUserRepository userRepository, IMapper mapper,ITokenService tokenService)
        {
            _userRepository = userRepository;
            _mapper = mapper;
            _tokenService = tokenService;
        }

        public async Task<LoginResponseUserDTO> Login(LoginUserDTO loginUserDTO)
        {
            string email = loginUserDTO.Email;
            string password = loginUserDTO.Password;
            var user = await _userRepository.Find(email, password);
            if(user == null) throw new Exception("Not found user!");
            UserDTO userDTO = _mapper.Map<UserDTO>(user);
            string token = _tokenService.CreateJwtToken(userDTO);
            
            return new LoginResponseUserDTO{
                Email = user.Email,
                Token = token
            };
        }

        public async Task<UserDTO> Register(RegisterUserDTO registerUserDTO)
        {
            var user = new User
            {
                Email = registerUserDTO.Email,
                Password = registerUserDTO.Password,
                DisplayName = registerUserDTO.DisplayName,
                ProfileImageLink = registerUserDTO.ProfileImageLink,
                PhoneNumber = registerUserDTO.PhoneNumber,
                Role = registerUserDTO.Role != null ? (Role)registerUserDTO.Role : Data.Enum.Role.Staff
            };

            await _userRepository.Add(user);
            return _mapper.Map<UserDTO>(user);
        }
    }
}
