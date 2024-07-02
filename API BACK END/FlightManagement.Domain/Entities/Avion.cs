using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Domain.Entities
{
    public class Avion
    {
        public int NumAvion { get; set; }
        public string NomAvion { get; set; }
        public int Capacite { get; set; }
        public string Localisation { get; set; }
    }
}
