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
    public class Evenement
    {
        [Key]
<<<<<<< HEAD
        public int Id_Evenement { get; set; }
=======
        public int Id { get; set; }
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d

        [Display(Name = "Nom de l'evenement")]
        public string Nom { get; set; }

        [Display(Name = "Type d'evenement")]
        public string Type { get; set; }

        public DateTime DateDebut { get; set; }

        public DateTime DateFin { get; set; }

        public string Description { get; set; }

<<<<<<< HEAD
        public float Prix { get; set; }

        //public int reservationId { get; set; }
=======
        public float prix { get; set; }

        public int reservationId { get; set; }
>>>>>>> 7fdb3180ad69afff04720e740d61633243ef9d8d

        [ForeignKey("reservationId")]
        public Reservation reservation { get; set; }
    }
}
