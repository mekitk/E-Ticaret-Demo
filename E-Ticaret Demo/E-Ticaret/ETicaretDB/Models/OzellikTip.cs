using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class OzellikTip
    {
        public string Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int KategoriId { get; set; }

        public virtual OzellikDeger IdNavigation { get; set; }
        public virtual Kategori Kategori { get; set; }
    }
}
