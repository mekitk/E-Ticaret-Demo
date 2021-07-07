using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_TicaretApi.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index(int id)
        {
            //KategoriRepository kt = new KategoriRepository();
            //var result = kt.GetirId(id);
            return View();
        }
    }
}
