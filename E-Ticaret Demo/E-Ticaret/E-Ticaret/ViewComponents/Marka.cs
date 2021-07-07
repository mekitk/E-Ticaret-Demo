using E_TicaretApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.ViewComponents
{
    public class Marka : ViewComponent
    {
        MarkaRepository marka;


        public Marka()
        {
            marka = new MarkaRepository();

        }


        public IViewComponentResult Invoke()
        {
            var markalist = marka.GetMarkaList();
            

            //List <Urun> urunler = new List<Urun>();
            //urunler = urunRepository.GetirHepsi();
            //await Task.Delay(10);

           
            return View(markalist);
        }
    }
}
