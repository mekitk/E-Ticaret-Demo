using ETicaretDB.Models;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    public class SepetRepository
    {
        private IHttpContextAccessor _httpcontextaccessor;
        public SepetRepository(IHttpContextAccessor httpcontextaccessor)
        {
            _httpcontextaccessor = httpcontextaccessor;
        }
        public void SepeteEkle(Urun urunn)
        {
            //var gelenliste = _httpcontextaccessor.HttpContext.Session
        }
    }

