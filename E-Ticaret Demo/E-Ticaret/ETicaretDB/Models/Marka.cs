using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Marka
    {
        [Key]
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string Resimyol { get; set; }
    }
}
