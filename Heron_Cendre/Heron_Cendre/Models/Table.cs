using Heron_Cendre.Data.Enum;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Table
    {
        [Key]

        public int Id_Table { get; set; }

        [Display(Name = "Nombre place")]

        /////////////enumeration de categorie/nombre de place des tables
        public CategorieTable table { get; set; }

        [ForeignKey("Reservation")]

        public Reservation reservation { get; set; } 
    }
}
