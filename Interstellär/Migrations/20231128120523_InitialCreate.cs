using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Interstellär.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    planet_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    distance_from_earth = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.planet_id);
                });

            migrationBuilder.CreateTable(
                name: "Visits",
                columns: table => new
                {
                    visit_id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    planet_id = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visits", x => x.visit_id);
                    table.ForeignKey(
                        name: "FK_Visits_Planets_planet_id",
                        column: x => x.planet_id,
                        principalTable: "Planets",
                        principalColumn: "planet_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "planet_id", "description", "distance_from_earth", "name" },
                values: new object[,]
                {
                    { 1, "Our home planet", 0.0, "Earth" },
                    { 2, "The red planet", 0.52000000000000002, "Mars" },
                    { 3, "Planet with a hot atmosphere", 0.28000000000000003, "Venus" },
                    { 4, "The eighth planet inour solar system", 30.07, "Neptune" },
                    { 5, "An exoplanet near Proxima Centauri", 48789776.240000002, "Proxima Centauri b" },
                    { 6, "The sixth planet in our solar system", 9.5800000000000001, "Saturn" },
                    { 7, "The seventh planet inour solar system", 19.18, "Uranus" },
                    { 8, "The largest planet in our solar system", 5.2000000000000002, "Jupiter" },
                    { 9, "The closest planet to the Sun", 0.60999999999999999, "Mercury" },
                    { 10, "A dwarf planet in oursolar system", 39.530000000000001, "Pluto" },
                    { 11, "An exoplanet orbiting Alpha Centauri B", 413893237.27999997, "Alpha Centauri Bb" },
                    { 12, "An exoplanet orbiting the red dwarf star Kepler - 186", 500000000.0, "Kepler-186f" },
                    { 13, "An exoplanet with a deep blue color", 63000000.0, "HD 189733 b" },
                    { 14, "An exoplanet inthe habitable zone of the TRAPPIST - 1 system", 39600000000.0, "TRAPPIST-1e" },
                    { 15, "An exoplanet orbiting Alpha Centauri C", 456789012.33999997, "Alpha Centauri Cb" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Visits_planet_id",
                table: "Visits",
                column: "planet_id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Visits");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
