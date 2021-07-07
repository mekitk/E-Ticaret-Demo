using ETicaretDB.DTO;
using ETicaretDB.Interfaces;
using ETicaretDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TicaretApi.Repositories
{
    public class MarkaRepository :  GenericRepository<Marka>, IMarkaRepository
    {

        ETicaretContext db = new ETicaretContext();
        public void Create(Marka marka)
        {
            db.Markas.Add(marka);
            db.SaveChanges();
        }

        public Marka Delete(int id)
        {
            var mark = db.Markas.Where(x => x.Id == id).FirstOrDefault();

            return mark;
        }

        public void Delete(Marka mrk)
        {
            ETicaretContext db = new ETicaretContext();

            List<MarkaListDTO> listmarka = new List<MarkaListDTO>();
            //var marka = db.Markas.Where(s => s.Id == mrk.Id).FirstOrDefault();
            //db.Markas.Remove(marka);
            //db.Markas.Add(mrk);
            db.Markas.Remove(mrk);
            db.SaveChanges();

        }
        public Marka Edit(int id)
        {
            var mark = db.Markas.Where(x => x.Id==id).FirstOrDefault();
            
            return mark;
        }
        

        public void Edit(Marka mrk)
        {
            ETicaretContext db = new ETicaretContext();

            List<MarkaListDTO> listmarka = new List<MarkaListDTO>();
            //var marka = db.Markas.Where(s => s.Id == mrk.Id).FirstOrDefault();
            //db.Markas.Remove(marka);
            //db.Markas.Add(mrk);
            db.Markas.Update(mrk);
            db.SaveChanges();

        }

        public Marka Details(int id)
        {
            var mark = db.Markas.Where(x => x.Id == id).FirstOrDefault();

            return mark;
        }


        public List<MarkaListDTO> GetMarkaList()
        {
            ETicaretContext db = new ETicaretContext();

            List<MarkaListDTO> markaListDTOs = new List<MarkaListDTO>();

            try
            {
                var markajoin = from mar in db.Markas


                                select new MarkaListDTO
                                {
                                    Id=mar.Id,
                                    Adi = mar.Adi,
                                    KucukYol = mar.Resimyol


                                };


                markaListDTOs = markajoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return markaListDTOs;
        }

    }
}
