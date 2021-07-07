using ETicaretDB.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.ViewComponents
{
    public class Favoriler : ViewComponent
    {
        IUrunRepository _urunRepository;
        public Favoriler(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }

        public IViewComponentResult Invoke(int id)
        {
            return View(_urunRepository.GetirId(id));
        }
    }
}
