using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TicaretApi.Interfaces
{
   public interface IGenericRepository<TEntity> where TEntity: class,new()

    {
         void Ekle(TEntity tablo);
         void Sil(TEntity tablo);
         void Guncelle(TEntity tablo);
         public List<TEntity> GetirHepsi();
         public TEntity GetirId(int id);
    }
}
