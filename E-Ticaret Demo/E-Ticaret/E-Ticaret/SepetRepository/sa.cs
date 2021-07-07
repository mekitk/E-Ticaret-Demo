using E_Ticaret.CustomExtensions;
using E_Ticaret.Interfaces;
using ETicaretDB.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.SepetRepository
{
    public class sa : ISepetRepository
    {
        private readonly IHttpContextAccessor _httpcontextaccessor;
        public sa(IHttpContextAccessor httpcontextaccessor)
        {
            _httpcontextaccessor = httpcontextaccessor;
        }
        public void SepeteEkle(Urun urun)
        {
            var gelenliste = _httpcontextaccessor.HttpContext.Session.GetObject<List<Urun>>("sepet");
            if (gelenliste == null)
            {
                gelenliste = new List<Urun>();
                gelenliste.Add(urun);
            }
            else
            {
                gelenliste.Add(urun);
            }
        }
        public void SepettenCikar(Urun urun)
        {
            var gelenliste = _httpcontextaccessor.HttpContext.Session.GetObject<List<Urun>>("sepet");
            gelenliste.Remove(urun);
            _httpcontextaccessor.HttpContext.Session.SetObject("sepet", gelenliste);

        }

    }
}
