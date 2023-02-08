using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Chambre
    {
        [Key]
        public int ChambreId { get; set; }

        [Display(Name = "Numero de chambre")]
        public string NumChambre { get; set; }

        [Display(Name = "Image de chambre")]
        public string Image { get; set; }

        [Display(Name = "Categorie de chambre")]
        public string Categorie { get; set; }

        [Display(Name = "Prix par heure")]
        public float prix { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        public int reservationId { get; set; }

        [ForeignKey("cinemaId")]
        public Reservation reservation { get; set; }
    }
}
