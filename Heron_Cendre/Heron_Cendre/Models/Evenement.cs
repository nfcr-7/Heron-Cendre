using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Evenement
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Nom de l'evenement")]
        public string Nom { get; set; }

        [Display(Name = "Type d'evenement")]
        public string Type { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public string Description { get; set; }

        public float prix { get; set; }

        public int reservationId { get; set; }

        [ForeignKey("reservationId")]
        public Reservation reservation { get; set; }
    }
}
