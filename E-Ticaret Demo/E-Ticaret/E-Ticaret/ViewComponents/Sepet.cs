using E_Ticaret.ViewModel;
using ETicaretDB.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace E_Ticaret.ViewComponents
{
    public class Sepet : ViewComponent
    {
        IUrunRepository _urunRepository;
        public Sepet(IUrunRepository urunRepository)
        {
            _urunRepository = urunRepository;
        }

        public IViewComponentResult Invoke()
        {
            var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            if (cart==null)
            {

            }
            else
            {
                ViewBag.cart = cart;
                ViewBag.total = cart.Sum(item => item.Product.SatisFiyat * item.Quantity);
            }
            
            return View();
        }
    }
}
