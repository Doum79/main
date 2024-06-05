using FightManagements.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Domain.Ports
{
    public interface IVolRepository
    {
        Task<IEnumerable<Vol>> GetAllFlightsAsync();
        Task AddFlightAsync(Vol vols);
    }
}
