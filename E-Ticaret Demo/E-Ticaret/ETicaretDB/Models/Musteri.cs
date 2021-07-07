using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Musteri
    {
        public Musteri()
        {
            Begenilers = new HashSet<Begeniler>();
            Favorilers = new HashSet<Favoriler>();
            MusteriAdres = new HashSet<MusteriAdre>();
            Satis = new HashSet<Sati>();
            Yorumlars = new HashSet<Yorumlar>();
        }

        public Guid Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public virtual AspnetUser IdNavigation { get; set; }
        public virtual ICollection<Begeniler> Begenilers { get; set; }
        public virtual ICollection<Favoriler> Favorilers { get; set; }
        public virtual ICollection<MusteriAdre> MusteriAdres { get; set; }
        public virtual ICollection<Sati> Satis { get; set; }
        public virtual ICollection<Yorumlar> Yorumlars { get; set; }
    }
}
