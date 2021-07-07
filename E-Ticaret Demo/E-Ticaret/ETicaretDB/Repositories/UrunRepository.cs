using ETicaretDB.DTO;
using ETicaretDB.Interfaces;
using ETicaretDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TicaretApi.Repositories
{
    public class UrunRepository : GenericRepository<Urun>, IUrunRepository
    {
        public List<UrunListDTO> GetUrunList()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               select new UrunListDTO
                               {
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }
        public UrunListDTO GetById(int id)
        {
            ETicaretContext db = new ETicaretContext();

            UrunListDTO urunListDTOs = new UrunListDTO();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               where ur.Id == id
                               select new UrunListDTO
                               {

                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public UrunListDTO GetBySearch(string id)
        {
            ETicaretContext db = new ETicaretContext();

            UrunListDTO urunListDTOs = new UrunListDTO();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               where ur.Adi == id
                               select new UrunListDTO
                               {

                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.FirstOrDefault();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> GetByKateBil()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 1
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> GetByKateKamera()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 3
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }
        public List<UrunListDTO> GetByKateTel()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 2
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> GetByKatePc()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 13
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }
        public List<UrunListDTO> GetByKateTV()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 4
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> GetByKateOfisKırtasiye()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 12
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }


        public List<UrunListDTO> GetByKateSpor()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 11
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }


        public List<UrunListDTO> GetByKateAksesuar()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 10
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> GetByKateKisisel()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 9
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> GetByKateEvMutfak()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 8
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }


        public List<UrunListDTO> GetByKateHobi()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 7
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> GetByKateOyun()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 6
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }
        public List<UrunListDTO> EvElektronigi()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == 4
                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> anasayfaurunler()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = (from ur in db.Uruns
                                join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                                join res in db.Resims on ur.Id equals res.UrunId
                                join kat in db.Kategoris on ur.KategoriId equals kat.Id

                                select new UrunListDTO
                                {
                                    KategoriAdi = kat.Adi,
                                    KategoriId = kat.Id,
                                    UrunId = ur.Id,
                                    Aciklama = ur.Aciklama,
                                    KucukYol = res.KucukYol,
                                    Ozellikler = urunoz.Ozellikler,
                                    Adi = ur.Adi,
                                    SatisFiyat = ur.SatisFiyat,
                                }).Take(5);


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }
        public List<UrunListDTO> Urunecs1()
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = (from ur in db.Uruns
                                join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                                join res in db.Resims on ur.Id equals res.UrunId
                                join kat in db.Kategoris on ur.KategoriId equals kat.Id

                                select new UrunListDTO
                                {
                                    KategoriAdi = kat.Adi,
                                    KategoriId = kat.Id,
                                    UrunId = ur.Id,
                                    Aciklama = ur.Aciklama,
                                    KucukYol = res.KucukYol,
                                    Ozellikler = urunoz.Ozellikler,
                                    Adi = ur.Adi,
                                    SatisFiyat = ur.SatisFiyat,
                                }).Take(6);


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }

        public List<UrunListDTO> AnaSayfaArama(string search, string search2)
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Adi == search || ur.Adi == search2 || urunoz.Ozellikler == search2

                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }



        public List<UrunListDTO> filtrelemecheck(int id )
        {
            ETicaretContext db = new ETicaretContext();

            List<UrunListDTO> urunListDTOs = new List<UrunListDTO>();

            try
            {
                var urunjoin = from ur in db.Uruns
                               join urunoz in db.UrunOzelliks on ur.Id equals urunoz.UrunId
                               join res in db.Resims on ur.Id equals res.UrunId
                               join kat in db.Kategoris on ur.KategoriId equals kat.Id
                               where kat.Id == id 

                               select new UrunListDTO
                               {
                                   KategoriAdi = kat.Adi,
                                   KategoriId = kat.Id,
                                   UrunId = ur.Id,
                                   Aciklama = ur.Aciklama,
                                   KucukYol = res.KucukYol,
                                   Ozellikler = urunoz.Ozellikler,
                                   Adi = ur.Adi,
                                   SatisFiyat = ur.SatisFiyat,
                               };


                urunListDTOs = urunjoin.ToList();
            }
            catch (Exception)
            {

                throw;
            }

            return urunListDTOs;
        }
    }
}