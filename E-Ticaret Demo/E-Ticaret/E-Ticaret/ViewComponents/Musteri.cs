using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.ViewComponents
{
    public class Musteri : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
