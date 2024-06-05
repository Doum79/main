using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Domain.Entities
{
    public class Vol
    {
        public string Numvol { get; set; }
        public int NumPilote { get; set; }
        public Pilote Pilotes { get; set; }
        public int NumAvion { get; set; }
        public Avion Avions { get; set; } // Propriété de navigation// Propriété de navigation
        public string Villedep { get; set; }
        public string? Villearr { get; set; }
        public string? Heuredep { get; set; }
        public string? Heurearr { get; set; }
    }
}
