using ETicaretDB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Controllers
{
    public class TestController : Controller
    {

        private readonly ETicaretContext _context;
        public TestController(ETicaretContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            ViewBag.IT = new SelectList(_context.Uruns.Select(i => i.Adi).ToList());
            ViewBag.FaName = new SelectList(_context.Kategoris.Select(i => i.Adi).ToList());
            ViewBag.CaName = new SelectList(_context.Markas.Select(i => i.Adi).ToList());
          
            return View();
        }
        [HttpGet]
        public async Task<ActionResult> Search(string Id, string Id2, string Id3)
        {
            var Result = from Res in _context.Uruns.Include(i => i.Adi)
                         .Include(i => i.Kategori)
                         //.Include(i => i.Marka)
                         select Res;

            if (!string.IsNullOrEmpty(Id))
            {
                Result = Result.Where(x => x.Adi.Contains(Id));
            }
            if (!string.IsNullOrEmpty(Id2))
            {
                Result = Result.Where(x => x.Kategori.Adi == Id2);
            }
            //if (!string.IsNullOrEmpty(Id3))
            //{
            //    //Result = Result.Where(x => x.Marka.Adi == Id3);
            //}
            return PartialView("_Search", await Result.ToListAsync());
        }
    }
}
