using ETicaretDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Interfaces
{
    public interface ISepetRepository
    {
       public void SepeteEkle(Urun urun);
        public void SepettenCikar(Urun urun);
    }
}
