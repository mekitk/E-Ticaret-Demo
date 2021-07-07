using E_TicaretApi.Repositories;
using ETicaretDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretDB.DTO
{
   public class UrunListDTO :UrunRepository
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public decimal AlisFiyat { get; set; }
        public decimal SatisFiyat { get; set; }
        public DateTime? EklenmeTarihi { get; set; }
        public DateTime? SonKullanmaTarihi { get; set; }

        public string KategoriAdi { get; set; }
        public int? KategoriId { get; set; }
        public int? MarkaId { get; set; }

        public int UrunId { get; set; }
        public string Ozellikler { get; set; }

        public string BuyukYol { get; set; }
        public string OrtaYol { get; set; }
        public string KucukYol { get; set; }
        public bool? Varsayilan { get; set; }
        public byte? SiraNo { get; set; }
        public UrunListDTO Product { get; set; }
        public int Quantity { get; set; }

    }
}
