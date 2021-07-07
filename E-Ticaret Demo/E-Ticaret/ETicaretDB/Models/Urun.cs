using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Urun
    {
        public Urun()
        {
            Resims = new HashSet<Resim>();
            SatisDetays = new HashSet<SatisDetay>();
            Yorumlars = new HashSet<Yorumlar>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public DateTime? SonKullanmaTarihi { get; set; }
        public int? KategoriId { get; set; }
        public string Marka { get; set; }

        public virtual Kategori Kategori { get; set; }
        public virtual UrunOzellik UrunOzellik { get; set; }
        public virtual ICollection<Resim> Resims { get; set; }
        public virtual ICollection<SatisDetay> SatisDetays { get; set; }
        public virtual ICollection<Yorumlar> Yorumlars { get; set; }
    }
}
