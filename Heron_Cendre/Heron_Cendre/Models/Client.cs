using System.ComponentModel.DataAnnotations;
<<<<<<< HEAD
using System.Xml.Linq;
=======
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d

namespace Heron_Cendre.Models
{
    public class Client
    {
        [Key]
<<<<<<< HEAD
        public int IdClient { get; set; }
=======
        public int Id { get; set; }
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d


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
<<<<<<< HEAD
        public DateTime DateNaissance { get; set; }

        [Display(Name = "Mot de passe Client")]
        public string MotPasse { get; set; }

        [Display(Name = "Numero de compte Client")]
        public int NCompte { get; set; }
=======
        public DateTime Naissance { get; set; }

        [Display(Name = "Mot de passe Client")]
        public string Passe { get; set; }

        [Display(Name = "Numero de compte Client")]
        public string NCompte { get; set; }
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d
    }
}
