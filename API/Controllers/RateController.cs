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
    public class RateController : ControllerBase
    {
        private readonly IRateService _rateService;

        public RateController(IRateService rateService)
        {
            _rateService = rateService;
        }

        [HttpGet]
        [ValidateModel]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<List<RateDTO>> GetAll()
        {
            var rates = await _rateService.GetAllAsync();
            return rates;
        }

        [HttpGet]
        [Route("{id:Guid}")]
        [ValidateModel]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<RateDTO> Get([FromRoute] Guid id)
        {
            var rate = await _rateService.GetAsync(id);
            return rate;
        }

        [HttpPost]
        [ValidateModel]
        [CustomAuthorize(Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Register([FromBody] RateDTO rateDTO)
        {
            var rs = await _rateService.AddAsync(rateDTO);
            return CreatedAtAction("GetRate", new { id = rs.Id }, rs);
        }

        [HttpDelete]
        [Route("{id:Guid}")]
        [CustomAuthorize(Role.Staff, Role.Landlord, Role.Admin)]
        public async Task<IActionResult> Delete([FromRoute] Guid id)
        {
            await _rateService.DeleteAsync(id);
            return Ok();
        }
    }
}
