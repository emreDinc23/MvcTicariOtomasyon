using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ProjeOkul.Models.Sınıflar
{
    public class mesajlar
    {
        [Key]
        public int MesajID { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Gönderici { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string Alici { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(50)]
        public string Konu { get; set; }
        [Column(TypeName = "Varchar")]
        [StringLength(2000)]
        public string icerik { get; set; }
        [Column(TypeName = "Date")]       
        public DateTime Tarih { get; set; }
    }
}