using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Heron_Cendre.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }


        [Display(Name = "Nom Client")]
        public string Nom { get; set; }


        [Display(Name = "Prenom Client")]
        public string Prenom { get; set; }


        [Display(Name = "Adresse Client")]
        public string Adresse { get; set; }

        [Display(Name = "Telephone Client")]
        public int Telephone { get; set; }

        [Display(Name = "Email Client")]
        public string Email { get; set; }

        [Display(Name = "Date de naissance Client")]
        public DateTime DateNaissance { get; set; }

        [Display(Name = "Mot de passe Client")]
        public string MotPasse { get; set; }

        [Display(Name = "Numero de compte Client")]
        public int NCompte { get; set; }

    }
}
