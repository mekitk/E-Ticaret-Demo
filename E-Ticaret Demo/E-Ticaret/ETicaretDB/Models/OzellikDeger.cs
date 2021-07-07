using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class OzellikDeger
    {
        public string Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public int OzellikTipId { get; set; }

        public virtual OzellikTip OzellikTip { get; set; }
    }
}
