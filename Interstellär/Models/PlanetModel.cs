using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interstellär.Models
{
    public class PlanetModel
    {
        [Key]
        [Column("planet_id")]
        public int PlanetId { get; set; }
        [Column("name")]
        public string Name { get; set; } = null!;
        [Column("description")]
        public string? Description { get; set; }
        [Column("distance_from_earth")]
        public double? DistanceFromEarth { get; set; }
        public List<VisitModel> Visits { get; set; }


    }
}
