using System;
using System.Collections.Generic;

#nullable disable

namespace ETicaretDB.Models
{
    public partial class Favoriler
    {
        public int Id { get; set; }
        public Guid FavoriId { get; set; }

        public virtual Musteri Favori { get; set; }
    }
}
