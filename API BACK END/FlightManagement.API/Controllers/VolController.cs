using FightManagements.Application.Services;
using FightManagements.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FightManagements.API.Controllers
{
    [Controller]
    [Route("api/[controller]")]
    public class VolController : ControllerBase
    {
        private readonly VolService _volService;

        public VolController(VolService volService)
        {
            _volService = volService;
        }

        [HttpGet("Vol")]
        public async Task<IEnumerable<Vol>> GetVol()
        {
            return await _volService.GetAllFlightsAsync();
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Vol vols)
        {
            await _volService.AddFlightAsync(vols);
            return Ok();
        }
    }
}
