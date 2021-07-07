using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class UrunOzellik
    {
        public int UrunId { get; set; }
        public string Ozellikler { get; set; }

        public virtual Urun Urun { get; set; }
    }
}
