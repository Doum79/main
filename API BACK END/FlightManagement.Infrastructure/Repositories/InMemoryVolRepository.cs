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
    public class InMemoryVolRepository : IVolRepository
    {
        private readonly ApplicationDbContext _context;

        public InMemoryVolRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Vol>> GetAllFlightsAsync()
        {
            return await _context.Vol.Include(f => f.Pilotes)
                                     .Include(f => f.Avions)
                                     .AsSplitQuery()
                                     .ToListAsync();
                            }
        public async Task AddFlightAsync(Vol vols)
        {
            await _context.Vol.AddAsync(vols);
            await _context.SaveChangesAsync();
        }

       
    }
}
