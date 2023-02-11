
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Heron_Cendre.Data.Enum;

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


        [Display(Name = "Prix par heure")]

        public float Prix { get; set; }

        public float prix { get; set; }


        [Display(Name = "Description")]
        public string Description { get; set; }

        //////////// Enumeration de la categorie des chambres
        public CategorieChambre categorie { get; set; }


        public int reservationId { get; set; }

        [ForeignKey("reservationId")]
        public Reservation reservation { get; set; }

    }
}
