using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace OgrIsler.Entities.Concrete
{
    public class OgrBilgi
    {
        
        [Required]
        public string Ogrno { get; set; }
        [StringLength(15),Required]
        public string Adi { get; set; }
        [StringLength(15), Required]
        public string Soyadi { get; set; }
        [Required]
        public bool Cinsiyet { get; set; }
        [Required]
        public DateTime Dtarih { get; set; }



    }
}
