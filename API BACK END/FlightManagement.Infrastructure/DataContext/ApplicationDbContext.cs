using FightManagements.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FightManagements.Infrastructure.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public DbSet<Vol> Vol { get; set; }
        public DbSet<Pilote> Pilote { get; set; }
        public DbSet<Avion> Avion { get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Avion>(entity =>
            {
                entity.HasKey(e => e.NumAvion); // Définir Id comme clé primaire
            });


            modelBuilder.Entity<Vol>(entity =>
            {
                entity.HasKey(e => e.Numvol); // Définir Id comme clé primaire
            });

            modelBuilder.Entity<Pilote>(entity =>
            {
                entity.HasKey(e => e.NumPilote); // Définir Id comme clé primaire
            });

            base.OnModelCreating(modelBuilder);

            // Configuration des relations
            modelBuilder.Entity<Vol>()
                .HasOne(f => f.Pilotes)
                .WithMany()
                .HasForeignKey(f => f.NumPilote);

            modelBuilder.Entity<Vol>()
                .HasOne(f => f.Avions)
                .WithMany()
                .HasForeignKey(f => f.NumAvion);

            base.OnModelCreating(modelBuilder);
        }
    }
}
