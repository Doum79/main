using FightManagements.Domain.Entities;
using FightManagements.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Application.Services
{
    public class PiloteService
    {
        private readonly IPiloteRepository _pilotRepository;

        public PiloteService(IPiloteRepository pilotRepository)
        {
            _pilotRepository = pilotRepository;
        }

        public async Task<IEnumerable<Pilote>> GetAllPilotsAsync()
        {
            return await _pilotRepository.GetAllPilotsAsync();
        }

    }
}
