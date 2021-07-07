using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Sati
    {
        public Sati()
        {
            SatisDetays = new HashSet<SatisDetay>();
        }

        public int Id { get; set; }
        public Guid? MusteriId { get; set; }
        public DateTime SatisTarihi { get; set; }
        public decimal ToplamTutar { get; set; }
        public bool? SepetMi { get; set; }
        public int? KargoId { get; set; }
        public int? SiparişDurumId { get; set; }
        public string KargoTakipNo { get; set; }

        public virtual Kargo Kargo { get; set; }
        public virtual Musteri Musteri { get; set; }
        public virtual SiparisDurum SiparişDurum { get; set; }
        public virtual ICollection<SatisDetay> SatisDetays { get; set; }
    }
}
