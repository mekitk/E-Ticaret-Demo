using E_TicaretApi.Repositories;
using ETicaretDB.Interfaces;
using ETicaretDB.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.ViewComponents
{
    public class Detay : ViewComponent
    {
        MarkaRepository marka;

        ETicaretContext db = new ETicaretContext();
        public IViewComponentResult Invoke(int id)
        {
            var mark = db.Markas.Where(x => x.Id == id).FirstOrDefault();

            return View(mark);
        }
    }
}
