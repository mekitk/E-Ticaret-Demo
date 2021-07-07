using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Yorumlar
    {
        public int Id { get; set; }
        public string Açıklama { get; set; }
        public Guid YorumId { get; set; }
        public int? UrunId { get; set; }

        public virtual Urun Urun { get; set; }
        public virtual Musteri Yorum { get; set; }
    }
}
