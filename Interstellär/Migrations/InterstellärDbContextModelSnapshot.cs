﻿// <auto-generated />
using System;
using Interstellär.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Interstellär.Migrations
{
    [DbContext(typeof(InterstellärDbContext))]
    partial class InterstellärDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Interstellär.Models.PlanetModel", b =>
                {
                    b.Property<int>("PlanetId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("planet_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PlanetId"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("description");

                    b.Property<double?>("DistanceFromEarth")
                        .HasColumnType("float")
                        .HasColumnName("distance_from_earth");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("PlanetId");

                    b.ToTable("Planets");

                    b.HasData(
                        new
                        {
                            PlanetId = 1,
                            Description = "Our home planet",
                            DistanceFromEarth = 0.0,
                            Name = "Earth"
                        },
                        new
                        {
                            PlanetId = 2,
                            Description = "The red planet",
                            DistanceFromEarth = 0.52000000000000002,
                            Name = "Mars"
                        },
                        new
                        {
                            PlanetId = 3,
                            Description = "Planet with a hot atmosphere",
                            DistanceFromEarth = 0.28000000000000003,
                            Name = "Venus"
                        },
                        new
                        {
                            PlanetId = 4,
                            Description = "The eighth planet inour solar system",
                            DistanceFromEarth = 30.07,
                            Name = "Neptune"
                        },
                        new
                        {
                            PlanetId = 5,
                            Description = "An exoplanet near Proxima Centauri",
                            DistanceFromEarth = 48789776.240000002,
                            Name = "Proxima Centauri b"
                        },
                        new
                        {
                            PlanetId = 6,
                            Description = "The sixth planet in our solar system",
                            DistanceFromEarth = 9.5800000000000001,
                            Name = "Saturn"
                        },
                        new
                        {
                            PlanetId = 7,
                            Description = "The seventh planet inour solar system",
                            DistanceFromEarth = 19.18,
                            Name = "Uranus"
                        },
                        new
                        {
                            PlanetId = 8,
                            Description = "The largest planet in our solar system",
                            DistanceFromEarth = 5.2000000000000002,
                            Name = "Jupiter"
                        },
                        new
                        {
                            PlanetId = 9,
                            Description = "The closest planet to the Sun",
                            DistanceFromEarth = 0.60999999999999999,
                            Name = "Mercury"
                        },
                        new
                        {
                            PlanetId = 10,
                            Description = "A dwarf planet in oursolar system",
                            DistanceFromEarth = 39.530000000000001,
                            Name = "Pluto"
                        },
                        new
                        {
                            PlanetId = 11,
                            Description = "An exoplanet orbiting Alpha Centauri B",
                            DistanceFromEarth = 413893237.27999997,
                            Name = "Alpha Centauri Bb"
                        },
                        new
                        {
                            PlanetId = 12,
                            Description = "An exoplanet orbiting the red dwarf star Kepler - 186",
                            DistanceFromEarth = 500000000.0,
                            Name = "Kepler-186f"
                        },
                        new
                        {
                            PlanetId = 13,
                            Description = "An exoplanet with a deep blue color",
                            DistanceFromEarth = 63000000.0,
                            Name = "HD 189733 b"
                        },
                        new
                        {
                            PlanetId = 14,
                            Description = "An exoplanet inthe habitable zone of the TRAPPIST - 1 system",
                            DistanceFromEarth = 39600000000.0,
                            Name = "TRAPPIST-1e"
                        },
                        new
                        {
                            PlanetId = 15,
                            Description = "An exoplanet orbiting Alpha Centauri C",
                            DistanceFromEarth = 456789012.33999997,
                            Name = "Alpha Centauri Cb"
                        });
                });

            modelBuilder.Entity("Interstellär.Models.VisitModel", b =>
                {
                    b.Property<int>("VisitId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("visit_id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("VisitId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("date");

                    b.Property<int>("PlanetId")
                        .HasColumnType("int")
                        .HasColumnName("planet_id");

                    b.HasKey("VisitId");

                    b.HasIndex("PlanetId");

                    b.ToTable("Visits");
                });

            modelBuilder.Entity("Interstellär.Models.VisitModel", b =>
                {
                    b.HasOne("Interstellär.Models.PlanetModel", "Planet")
                        .WithMany("Visits")
                        .HasForeignKey("PlanetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planet");
                });

            modelBuilder.Entity("Interstellär.Models.PlanetModel", b =>
                {
                    b.Navigation("Visits");
                });
#pragma warning restore 612, 618
        }
    }
}
