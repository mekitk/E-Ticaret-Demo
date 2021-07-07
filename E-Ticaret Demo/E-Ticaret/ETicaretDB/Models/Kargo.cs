using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Kargo
    {
        public Kargo()
        {
            Satis = new HashSet<Sati>();
        }

        public int Id { get; set; }
        public string SirketAdi { get; set; }
        public string Adres { get; set; }
        public string Telefon { get; set; }
        public string WebSite { get; set; }
        public string Email { get; set; }

        public virtual ICollection<Sati> Satis { get; set; }
    }
}
