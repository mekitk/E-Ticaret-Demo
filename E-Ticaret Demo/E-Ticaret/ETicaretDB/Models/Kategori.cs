using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Kategori
    {
        public Kategori()
        {
            OzellikTips = new HashSet<OzellikTip>();
            Uruns = new HashSet<Urun>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int? ResimId { get; set; }

        public virtual Resim Resim { get; set; }
        public virtual ICollection<OzellikTip> OzellikTips { get; set; }
        public virtual ICollection<Urun> Uruns { get; set; }
    }
}
