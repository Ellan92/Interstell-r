using Interstellär.Models;
using Microsoft.EntityFrameworkCore;

namespace Interstellär.Data
{
    public class InterstellärDbContext : DbContext
    {
        public InterstellärDbContext()
        {

        }

        public DbSet<PlanetModel> Planets { get; set; }
        public DbSet<VisitModel> Visits { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);

            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=InterstellärDb;Trusted_Connection=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PlanetModel>().HasData(
            new PlanetModel
            {
                PlanetId = 1,
                Name = "Earth",
                Description = "Our home planet",
                DistanceFromEarth = 0
            },
            new PlanetModel
            {
                PlanetId = 2,
                Name = "Mars",
                Description = "The red planet",
                DistanceFromEarth = 0.52
            },
            new PlanetModel
            {
                PlanetId = 3,
                Name = "Venus",
                Description = "Planet with a hot atmosphere",
                DistanceFromEarth = 0.28
            },
            new PlanetModel
            {
                PlanetId = 4,
                Name = "Neptune",
                Description = "The eighth planet inour solar system",
                DistanceFromEarth = 30.07
            },
            new PlanetModel
            {
                PlanetId = 5,
                Name = "Proxima Centauri b",
                Description = "An exoplanet near Proxima Centauri",
                DistanceFromEarth = 48789776.24
            },
            new PlanetModel
            {
                PlanetId = 6,
                Name = "Saturn",
                Description = "The sixth planet in our solar system",
                DistanceFromEarth = 9.58
            },
            new PlanetModel
            {
                PlanetId = 7,
                Name = "Uranus",
                Description = "The seventh planet inour solar system",
                DistanceFromEarth = 19.18
            },
            new PlanetModel
            {
                PlanetId = 8,
                Name = "Jupiter",
                Description = "The largest planet in our solar system",
                DistanceFromEarth = 5.20
            },
            new PlanetModel
            {
                PlanetId = 9,
                Name = "Mercury",
                Description = "The closest planet to the Sun",
                DistanceFromEarth = 0.61
            },
            new PlanetModel
            {
                PlanetId = 10,
                Name = "Pluto",
                Description = "A dwarf planet in oursolar system",
                DistanceFromEarth = 39.53
            },
            new PlanetModel
            {
                PlanetId = 11,
                Name = "Alpha Centauri Bb",
                Description = "An exoplanet orbiting Alpha Centauri B",
                DistanceFromEarth = 413893237.28
            },
            new PlanetModel
            {
                PlanetId = 12,
                Name = "Kepler-186f",
                Description = "An exoplanet orbiting the red dwarf star Kepler - 186",
                DistanceFromEarth = 500000000.00
            },
            new PlanetModel
            {
                PlanetId = 13,
                Name = "HD 189733 b",
                Description = "An exoplanet with a deep blue color",
                DistanceFromEarth = 63000000.00
            },
            new PlanetModel
            {
                PlanetId = 14,
                Name = "TRAPPIST-1e",
                Description = "An exoplanet inthe habitable zone of the TRAPPIST - 1 system",
                DistanceFromEarth = 39600000000.00
            },
            new PlanetModel
            {
                PlanetId = 15,
                Name = "Alpha Centauri Cb",
                Description = "An exoplanet orbiting Alpha Centauri C",
                DistanceFromEarth = 456789012.34
            });
        }
    }
}
