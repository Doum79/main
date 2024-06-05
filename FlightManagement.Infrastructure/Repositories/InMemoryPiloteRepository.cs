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
    public class InMemoryPiloteRepository : IPiloteRepository
    {
        private readonly ApplicationDbContext _context;

        public InMemoryPiloteRepository(ApplicationDbContext context)
        {
            _context = context;
        }
       public async Task<IEnumerable<Pilote>> GetAllPilotsAsync()
        {
            return await _context.Pilote.ToListAsync();
        }
    }
}
