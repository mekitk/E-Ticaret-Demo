using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Resim
    {
        public Resim()
        {
            Kategoris = new HashSet<Kategori>();
        }

        public int Id { get; set; }
        public string BuyukYol { get; set; }
        public string OrtaYol { get; set; }
        public string KucukYol { get; set; }
        public bool? Varsayilan { get; set; }
        public byte? SiraNo { get; set; }
        public int? UrunId { get; set; }

        public virtual Urun Urun { get; set; }
        public virtual ICollection<Kategori> Kategoris { get; set; }
    }
}
