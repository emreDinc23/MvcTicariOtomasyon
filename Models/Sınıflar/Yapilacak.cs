﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjeOkul.Models.Sınıflar
{
    public class Yapilacak
    {
        [Key]
        public int Yapilacakid { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Baslik { get; set; }
        [Column(TypeName = "bit")]
        public bool Durum { get; set; }

    }
}