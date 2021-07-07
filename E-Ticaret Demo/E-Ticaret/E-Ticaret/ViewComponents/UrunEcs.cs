using E_TicaretApi.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.ViewComponents
{
    public class UrunEcs : ViewComponent
    {

        UrunRepository urunRepository;
        UrunOzellikRepository urunozellikrepository;
        ResimRepository resimrepository;
        //private readonly I
        public UrunEcs()
        {
            urunRepository = new UrunRepository();
            urunozellikrepository = new UrunOzellikRepository();
            resimrepository = new ResimRepository();
        }
        public IViewComponentResult Invoke()
        {
            var result = urunRepository.Urunecs1();
            return View(result);
        }
    }
}
