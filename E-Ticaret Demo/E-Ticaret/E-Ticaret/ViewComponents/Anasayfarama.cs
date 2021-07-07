using E_TicaretApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.ViewComponents
{
    public class Anasayfarama : ViewComponent
    {
        UrunRepository urunRepository;
        UrunOzellikRepository urunozellikrepository;
        ResimRepository resimrepository;
        //private readonly I
        public Anasayfarama()
        {
            urunRepository = new UrunRepository();
            urunozellikrepository = new UrunOzellikRepository();
            resimrepository = new ResimRepository();
        }
        public IViewComponentResult Invoke(/*string s1,string s2*/)
        {
            //var test = ViewBag.SelectList;
            //var result = urunRepository.AnaSayfaArama(s1,s2);
            return View(/*result*/);
        }
    }
}
