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
    public class RoomController : ControllerBase
    {
        private readonly IRoomService _roomService;

        public RoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [HttpGet]
        [ValidateModel]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<List<RoomDTO>> GetAll([FromQuery] FilterRoomDTO query)
        {
            // string email = Room.FindFirst(ClaimTypes.Email).Value;
            var rooms = await _roomService.GetAllAsync(query);
            return rooms;
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [ValidateModel]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<RoomDTO> Get([FromRoute] Guid id)
        {
            // string email = Room.FindFirst(ClaimTypes.Email).Value;
            var Room = await _roomService.GetAsync(id);
            return Room;
        }

        [HttpPost]
        [ValidateModel]
        [CustomAuthorize(Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Register([FromBody] RoomDTO roomDTO)
        {
            string email = User.FindFirst(ClaimTypes.Email).Value;
            string role = User.FindFirst(ClaimTypes.Role).Value;
            if (role == ((int)Role.Admin).ToString())
            {
                var rs = await _roomService.AddAsync(roomDTO);
                return Ok(rs);
            }
            else
            {
                var rs = await _roomService.AddAsync(roomDTO, email);
                return Ok(rs);
            }
        }


        [HttpPut]
        [Route("{id:Guid}")]
        [CustomAuthorize(Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid id,
            [FromBody] RoomUpdateDTO roomUpdateDTO
        )
        {
            string role = User.FindFirst(ClaimTypes.Role).Value;
            string email = User.FindFirst(ClaimTypes.Email).Value;
            if (role == ((int)Role.Admin).ToString())
            {
                await _roomService.UpdateAsync<RoomUpdateDTO>(roomUpdateDTO, id);
            }
            else
            {
                await _roomService.UpdateAsync(roomUpdateDTO, id, email);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [CustomAuthorize(Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            string role = User.FindFirst(ClaimTypes.Role).Value;
            string email = User.FindFirst(ClaimTypes.Email).Value;
            if (role == ((int)Role.Admin).ToString())
            {
                await _roomService.DeleteAsync(id);
            }
            else
            {
                await _roomService.DeleteAsync(id, email);
            }
            return Ok();
        }
    }
}
