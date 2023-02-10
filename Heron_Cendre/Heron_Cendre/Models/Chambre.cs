<<<<<<< HEAD
﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
=======
﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d

namespace Heron_Cendre.Models
{
    public class Chambre
    {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d
        [Key]
        public int ChambreId { get; set; }

        [Display(Name = "Numero de chambre")]
        public string NumChambre { get; set; }

        [Display(Name = "Image de chambre")]
        public string Image { get; set; }

        [Display(Name = "Categorie de chambre")]
        public string Categorie { get; set; }

        [Display(Name = "Prix par heure")]
<<<<<<< HEAD
        public float Prix { get; set; }
=======
        public float prix { get; set; }
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d

        [Display(Name = "Description")]
        public string Description { get; set; }

<<<<<<< HEAD
        //public int reservationId { get; set; }

        [ForeignKey("cinemaId")]
        public Reservation reservation { get; set; }
=======
        public int reservationId { get; set; }

        [ForeignKey("cinemaId")]
        public Reservation reservation { get; set; }
=======

>>>>>>> f4a186c886d2e34e279b4514b1b6a43c46029e19
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d
    }
}
