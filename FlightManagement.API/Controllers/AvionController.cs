using FightManagements.Application.Services;
using FightManagements.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FightManagements.API.Controllers
{
    [Controller]
    [Route("api/controller")]
    public class AvionController : ControllerBase
    {
        private readonly AvionService _avionServices;

        public AvionController(AvionService avionServices)
        {
            _avionServices = avionServices;
        }

        [HttpGet("Avion")]
        public async Task<IEnumerable<Avion>> GetAvion()
        {
            return await _avionServices.GetAllAircraftAsync();
        }
    }
}
