using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class SatisDetay
    {
        public int SatisId { get; set; }
        public int UrunId { get; set; }
        public int? Adet { get; set; }
        public decimal? Fiyat { get; set; }
        public double? İndirim { get; set; }

        public virtual Sati Satis { get; set; }
        public virtual Urun Urun { get; set; }
    }
}
