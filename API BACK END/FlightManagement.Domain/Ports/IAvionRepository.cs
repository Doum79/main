﻿using FightManagements.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Domain.Ports
{
    public interface IAvionRepository
    {
        Task<IEnumerable<Avion>> GetAllAircraftAsync();
    }
}
