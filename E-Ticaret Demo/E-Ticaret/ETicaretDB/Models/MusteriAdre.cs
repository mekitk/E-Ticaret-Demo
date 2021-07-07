using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class MusteriAdre
    {
        public int Id { get; set; }
        public Guid MusteriId { get; set; }
        public string Adres { get; set; }
        public string Adi { get; set; }

        public virtual Musteri Musteri { get; set; }
    }
}
