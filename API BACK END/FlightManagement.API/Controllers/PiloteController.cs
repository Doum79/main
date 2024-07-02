using FightManagements.Application.Services;
using FightManagements.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FightManagements.API.Controllers
{
    [Controller]
    [Route("api/controller")]
    public class PiloteController : ControllerBase
    {
        private readonly PiloteService _pilotServices;

        public PiloteController(PiloteService pilotServices)
        {
            _pilotServices = pilotServices;
        }

        [HttpGet("Pilote")]
        public async Task<IEnumerable<Pilote>> GetPilote()
        {
            return await _pilotServices.GetAllPilotsAsync();
        }

    }
}
