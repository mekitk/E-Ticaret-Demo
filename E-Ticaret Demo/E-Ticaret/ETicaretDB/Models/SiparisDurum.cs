using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class SiparisDurum
    {
        public SiparisDurum()
        {
            Satis = new HashSet<Sati>();
        }

        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }

        public virtual ICollection<Sati> Satis { get; set; }
    }
}
