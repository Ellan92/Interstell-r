using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Interstellär.Models
{
    public class VisitModel
    {
        [Key]
        [Column("visit_id")]
        public int VisitId { get; set; }
        [Column("date")]
        public DateTime Date { get; set; }
        [Column("planet_id")]
        public int PlanetId { get; set; }
        public PlanetModel Planet { get; set; }

    }
}
