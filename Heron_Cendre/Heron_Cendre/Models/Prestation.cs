using Heron_Cendre.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Prestation
    {
        public int Id_Prestation { get; set; }

        [Display(Name = "Nom service")]

        public string Nom_Service { get; set; }

        [Display(Name = "Description")]

        public string Description { get; set; }

        [Display(Name = "Date debut")]

        public DateTime Date_Debut { get; set; }

        [Display(Name = "Date fin")]

        public DateTime Date_Fin { get; set; }

        [ForeignKey("Reservation")]

        public ReservationE ReservationE { get; set; }

        [Display(Name = "Prix")]

        public float Prix { get; set; }
    }
}
