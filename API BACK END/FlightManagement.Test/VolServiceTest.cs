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
    public class VolServiceTest
    {
        private readonly Mock<IVolRepository> _volRepo;
        private readonly VolService _volServices;

        public VolServiceTest()
        {
            _volRepo = new Mock<IVolRepository>();

            _volServices = new VolService(_volRepo.Object);
        }


        [Fact]
        public async Task Ajouter_Le_Vol_prevu()
        {
            // Arrange
            var newVol = new Vol
            { Numvol = "F00070",
                Villedep = "Paris",
                Villearr = "Abidjan",
                Heuredep = "14h30",
                Heurearr = "21h30",
                NumPilote = 3,
                NumAvion = 1 
            };
            _volRepo.Setup(repo => repo.AddFlightAsync(It.IsAny<Vol>())).Returns(Task.CompletedTask);

            // Act
            await _volServices.AddFlightAsync(newVol);

            // Assert
            _volRepo.Verify(repo => repo.AddFlightAsync(It.Is<Vol>(f => f.Villedep == "Paris" && f.NumPilote == 3 && f.NumAvion == 1)), Times.Once);
        }
    }
    
}
