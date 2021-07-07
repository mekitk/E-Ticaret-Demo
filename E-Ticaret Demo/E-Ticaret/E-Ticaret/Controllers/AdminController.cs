using E_TicaretApi.Repositories;
using ETicaretDB.Interfaces;
using ETicaretDB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Controllers
{
    public class AdminController : Controller
    {

        MusteriRepository YY;
        MarkaRepository MR;

        public AdminController()
        {
            YY = new MusteriRepository();
            MR = new MarkaRepository();
        }
        //[Authorize]
        public IActionResult Index()
        {
            TempData["musteri"] = YY.GetMusteriCount();
            return View();
        }
        public IActionResult musterilist()
        {
            var result = YY.GetMusteriList();
            return View(result);
        }

        public IActionResult markalist()
        {
            var result = MR.GetMarkaList();
            return View(result);
        }
        
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Marka marka)
        {
            MR.Create(marka);
            return RedirectToAction("markalist", "admin");
        }

        public IActionResult Edit(int id)
        {
           //Marka result = MR.Edit(id);
            Marka result = MR.GetirId(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Edit(Marka mrk)
        {
            Marka marka = MR.Edit(mrk.Id);
            marka.Aciklama = mrk.Aciklama;
            marka.Adi = mrk.Adi;
            marka.Resimyol = mrk.Resimyol;
            MR.Edit(marka);
            return RedirectToAction("markalist","admin");

        }
        public IActionResult Delete(int id)
        {
            //Marka result = MR.Edit(id);
            Marka result = MR.GetirId(id);
            return View(result);
        }
        [HttpPost]
        public IActionResult Delete(Marka mrk)
        {
            Marka marka = MR.Delete(mrk.Id);
            marka.Aciklama = mrk.Aciklama;
            marka.Adi = mrk.Adi;
            marka.Resimyol = mrk.Resimyol;
            MR.Delete(marka);
            return RedirectToAction("markalist", "admin");

        }

        public IActionResult edddd(Marka mrk)
        {
            MR.Edit(mrk);
            return RedirectToAction("markalist", "admin");

        }
        public IActionResult Detail(int id)
        {
            var detail= MR.Details(id);
            return RedirectToAction("Detay", "admin",detail);

        }
    }
}
