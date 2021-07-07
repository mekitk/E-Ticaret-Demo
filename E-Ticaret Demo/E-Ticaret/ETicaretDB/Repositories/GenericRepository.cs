using ETicaretDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TicaretApi.Repositories
{
    public class GenericRepository<TEntity> where TEntity:class,new()

    {
        public void Ekle(TEntity tablo)
        {
            using var context= new ETicaretContext();
            context.Set<TEntity>().Add(tablo);
            context.SaveChanges();

        }

        public void Guncelle(TEntity tablo)
        {
            using var context = new ETicaretContext();
            context.Set<TEntity>().Update(tablo);
            context.SaveChanges();

        }

        public void Sil(TEntity tablo)
        {
            using var context = new ETicaretContext();
            context.Set<TEntity>().Remove(tablo);
            context.SaveChanges();

        }

        public List<TEntity> GetirHepsi()
        {
            using var context = new ETicaretContext();
            return context.Set<TEntity>().ToList();
        }

        public TEntity GetirId(int id)
        {
            using var context = new ETicaretContext();
            return context.Set<TEntity>().Find(id);
        }
    }
}
