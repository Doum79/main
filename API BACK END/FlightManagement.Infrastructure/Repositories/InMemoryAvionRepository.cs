using FightManagements.Domain.Entities;
using FightManagements.Domain.Ports;
using FightManagements.Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Infrastructure.Repositories
{
    public class InMemoryAvionRepository : IAvionRepository
    {
        private readonly ApplicationDbContext _context;

        public InMemoryAvionRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Avion>> GetAllAircraftAsync()
        {
            return await _context.Avion
                                .AsNoTracking()
                                .ToListAsync();
        }
    }
}
