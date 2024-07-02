using FightManagements.Application.Services;
using FightManagements.Domain.Entities;
using FightManagements.Domain.Ports;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Test
{
    public class AvionServiceTest
    {
        private readonly Mock<IAvionRepository> _avionRepo;
        private readonly AvionService _avionService;

        public AvionServiceTest()
        {
            _avionRepo = new Mock<IAvionRepository>();

            _avionService = new AvionService(_avionRepo.Object);

        }

        [Fact]
        public async Task Verifier_Si_La_Liste_Des_Avions_Est_Vide()
        {
            // Arrange
            var avion = new List<Avion>
        {
           
        };
            _avionRepo.Setup(repo => repo.GetAllAircraftAsync()).ReturnsAsync(avion);

            // Act
            var result = await _avionService.GetAllAircraftAsync();

            // Assert
            Assert.Empty("");
        }

        [Fact]
        public async Task Recuperer_La_Liste_de_Tous_Les_Avions()
        {
            // Arrange
            var avion = new List<Avion>
        {
            new Avion { NumAvion = 1, NomAvion = "AirParis" },
            new Avion { NumAvion = 2, NomAvion = "Air Cote D'Ivoire" }
        };
            _avionRepo.Setup(repo => repo.GetAllAircraftAsync()).ReturnsAsync(avion);

            // Act
            var result = await _avionService.GetAllAircraftAsync();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, f => f.NomAvion == "AirParis");
            Assert.Contains(result, f => f.NomAvion == "Air Cote D'Ivoire");
        }
    }
}
