﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Heron_Cendre.Models
{
    public class Table
    {
        [Key]

        public int Id_Table { get; set; }

        [Display(Name = "Nombre place")]

        public int Nombre_Place { get; set; }

        [ForeignKey("Reservation")]

        public Reservation reservation { get; set; } 
    }
}
