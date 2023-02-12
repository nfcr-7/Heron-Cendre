using Heron_Cendre.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Reservation
    {
        [Key]

        public int Id_Reservation { get; set; }

        [Display(Name = "Date debut")]

        public DateTime Date_Debut { get; set; }

        [Display(Name = "Date fin")]

        public DateTime Date_Fin { get; set; }

        public ModePayement payement { get; set; }

        [ForeignKey("Client")]

        public Client client { get; set; }
    }
}
