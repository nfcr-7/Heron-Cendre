using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Menu
    {
        [Key]

        public int Id_Menu { get; set; }

        [Display (Name = "Nom_Repas")]

        public string Nom_Repas { get; set; }

        [Display (Name = "Image_Repas")]

        public string Image_Repas { get; set; }

        [ForeignKey ("Id_Reservation")]

        public Reservation reservationre { get; set; }

        [Display(Name = "Prix")]

        public float Prix { get; set; }

        [Display(Name = "Categorie")]

        public string Categorie { get; set; }   

    }
}
