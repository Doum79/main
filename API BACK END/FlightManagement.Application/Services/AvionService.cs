using FightManagements.Domain.Entities;
using FightManagements.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Application.Services
{
    public class AvionService
    {
        private readonly IAvionRepository _avionRepository;

        public AvionService(IAvionRepository avionRepository)
        {
            _avionRepository = avionRepository;
        }

        public async Task<IEnumerable<Avion>> GetAllAircraftAsync()
        {
            return await _avionRepository.GetAllAircraftAsync();
        }
    }

}
