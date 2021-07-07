using E_TicaretApi.Repositories;
using ETicaretDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Controllers
{
    public class UrunController : Controller
    {
        UrunRepository urunRepository;
        
        public UrunController()
        {
            urunRepository = new UrunRepository();
           
        }
        public IActionResult Index(int id)
        {
            var result = urunRepository.GetById(id);
            return View(result);
        }
    }
}
