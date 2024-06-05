using FightManagements.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Domain.Ports
{
    public interface IPiloteRepository
    {
        Task<IEnumerable<Pilote>> GetAllPilotsAsync();
    }
}
