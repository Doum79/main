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
    public class PiloteServiceTest
    {

        private readonly Mock<IPiloteRepository> _pilotRepo;
        private readonly PiloteService _pilotServices;

        public PiloteServiceTest()
        {
            _pilotRepo = new Mock<IPiloteRepository>();

            _pilotServices = new PiloteService(_pilotRepo.Object);
        }

        [Fact]
        public async Task Verifier_Si_La_Liste_Des_Pilotes_Est_Vide()
        {
            // Arrange
            var pilote = new List<Pilote>
            {

            };
            _pilotRepo.Setup(repo => repo.GetAllPilotsAsync()).ReturnsAsync(pilote);

            // Act
            var result = await _pilotServices.GetAllPilotsAsync();

            // Assert
            Assert.Empty("");
        }


        [Fact]
        public async Task recuperer_La_Liste_de_Tous_Les_Avion()
        {
            // Arrange
            var pilote = new List<Pilote>
        {
            new Pilote { NumPilote = 1, NomPilote = "Aziz" },
            new Pilote { NumPilote = 2, NomPilote = "Ahmed" }
        };
            _pilotRepo.Setup(repo => repo.GetAllPilotsAsync()).ReturnsAsync(pilote);

            // Act
            var result = await _pilotServices.GetAllPilotsAsync();

            // Assert
            Assert.Equal(2, result.Count());
            Assert.Contains(result, f => f.NomPilote == "Aziz");
            Assert.Contains(result, f => f.NomPilote == "Ahmed");
        }
    }
}
