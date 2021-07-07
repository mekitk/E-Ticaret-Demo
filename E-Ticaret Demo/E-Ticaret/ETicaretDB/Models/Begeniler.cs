using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Begeniler
    {
        public int Id { get; set; }
        public string Puan { get; set; }
        public Guid BegeniId { get; set; }

        public virtual Musteri Begeni { get; set; }
    }
}
