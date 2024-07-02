using FightManagements.Domain.Entities;
using FightManagements.Domain.Ports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Application.Services
{
    public class VolService
    {
        private readonly IVolRepository _volRepository;

        public VolService(IVolRepository volRepository)
        {
            _volRepository = volRepository;
        }

        public async Task<IEnumerable<Vol>> GetAllFlightsAsync()
        {
            return await _volRepository.GetAllFlightsAsync();
        }

        public async Task AddFlightAsync(Vol vols)
        {
            await _volRepository.AddFlightAsync(vols);
        }

    }
}
