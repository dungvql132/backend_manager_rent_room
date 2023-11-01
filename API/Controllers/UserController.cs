using System.Data;
using System.Security.Claims;
using API.Validate;
using BusinessLayer.DTOs;
using BusinessLayer.Interfaces;
using CustomAuthorizetion;
using Data.Enum;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;


namespace test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IAuthenService _authenService;
        private readonly IUserService _userService;

        public UserController(IAuthenService authenService, IUserService userService)
        {
            _authenService = authenService;
            _userService = userService;
        }

        [HttpGet]
        [ValidateModel]
        [CustomAuthorize(Role.Staff, Role.Admin)]
        public async Task<List<UserDTO>> Get()
        {
            // string email = User.FindFirst(ClaimTypes.Email).Value;
            var users = await _userService.GetAllAsync();
            return users;
        }

        [HttpPost]
        [ValidateModel]
        [Route("login")]
        public async Task<IActionResult> Login([FromBody] LoginUserDTO loginUserDTO)
        {
            var rs = await _authenService.Login(loginUserDTO);

            return Ok(rs);
        }

        [HttpPost]
        [ValidateModel]
        [Route("register")]
        public async Task<IActionResult> Register([FromBody] RegisterUserDTO registerUserDTO)
        {
            var rs = await _authenService.Register(registerUserDTO);
            return Ok(rs);
        }

        [HttpPut]
        [Route("{id:Guid}")]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid id,
            [FromBody] UserUpdateDTO userUpdateDTO
        )
        {
            string role = User.FindFirst(ClaimTypes.Role).Value;
            string email = User.FindFirst(ClaimTypes.Email).Value;
            if (role == ((int)Role.Admin).ToString())
            {
                await _userService.UpdateAsync<UserUpdateDTO>(userUpdateDTO, id);
            }
            else
            {
                UserDTO userDTO = await _userService.GetAsync(id);
                if (userDTO.Email == email)
                {
                    await _userService.UpdateAsync<UserUpdateDTO>(userUpdateDTO, id);
                }else{
                    throw new UnauthorizedAccessException("Only update yourself");
                }
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _userService.DeleteAsync(id);
            return Ok();
        }
    }
}
