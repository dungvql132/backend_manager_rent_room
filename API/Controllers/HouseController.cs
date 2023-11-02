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
    public class HouseController : ControllerBase
    {
        private readonly IHouseService _houseService;

        public HouseController(IHouseService houseService)
        {
            _houseService = houseService;
        }

        [HttpGet]
        [ValidateModel]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<List<HouseDTO>> GetAll([FromQuery] FilterHouseDTO query)
        {
            // string email = House.FindFirst(ClaimTypes.Email).Value;
            var houses = await _houseService.GetAllAsync(query);
            return houses;
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [ValidateModel]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<HouseDTO> Get([FromRoute] Guid id)
        {
            // string email = House.FindFirst(ClaimTypes.Email).Value;
            var house = await _houseService.GetAsync(id);
            return house;
        }

        [HttpPost]
        [ValidateModel]
        [CustomAuthorize(Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Register([FromBody] HouseDTO houseDTO)
        {
            var rs = await _houseService.AddAsync(houseDTO);
            return Ok(rs);
        }


        [HttpPut]
        [Route("{id:Guid}")]
        [CustomAuthorize(Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Update(
            [FromRoute] Guid id,
            [FromBody] HouseUpdateDTO houseUpdateDTO
        )
        {
            string role = User.FindFirst(ClaimTypes.Role).Value;
            string email = User.FindFirst(ClaimTypes.Email).Value;
            if (role == ((int)Role.Admin).ToString())
            {
                await _houseService.UpdateAsync<HouseUpdateDTO>(houseUpdateDTO, id);
            }
            else
            {
                await _houseService.UpdateAsync(houseUpdateDTO,id,email);
            }
            return Ok();
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _houseService.DeleteAsync(id);
            return Ok();
        }
    }
}
