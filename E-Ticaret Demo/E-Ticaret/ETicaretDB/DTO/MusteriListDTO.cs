using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using E_TicaretApi.Repositories;

namespace ETicaretDB.DTO
{
    public class MusteriListDTO : MusteriRepository
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KullaniciAdi { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }

        public string Adres { get; set; }

    }
}
