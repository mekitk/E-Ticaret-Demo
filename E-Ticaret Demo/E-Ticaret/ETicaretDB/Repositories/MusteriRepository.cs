using ETicaretDB.DTO;
using ETicaretDB.Interfaces;
using ETicaretDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TicaretApi.Repositories
{
    public class MusteriRepository : GenericRepository<Musteri>, IMusteriRepository
    {
        public int GetMusteriCount()
        {
            ETicaretContext db = new ETicaretContext();

            int musteriListDTOs;

            try
            {
                var musterisayisi =  db.Musteris.Count();

                musteriListDTOs = musterisayisi;
                
            }
            catch (Exception)
            {

                throw;
            }

            return musteriListDTOs;
        }

        public List<MusteriListDTO> GetMusteriList()
        {
            ETicaretContext db = new ETicaretContext();

            List<MusteriListDTO> musteriListDTOs = new List<MusteriListDTO>();

            try
            {
                var musterijoin = from Mus in db.Musteris
                               join musadres in db.MusteriAdres on Mus.Id equals musadres.MusteriId
                                
                                  select new MusteriListDTO
                               {
                                   
                                   Adi = Mus.Adi,
                                   Soyadi =Mus.Soyadi ,
                                   KullaniciAdi =Mus.KullaniciAdi ,
                                   Email = Mus.Email,
                                   Telefon =Mus.Telefon ,
                                   Adres=musadres.Adres
                               };


                musteriListDTOs = musterijoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return musteriListDTOs;
        }
    }
}
