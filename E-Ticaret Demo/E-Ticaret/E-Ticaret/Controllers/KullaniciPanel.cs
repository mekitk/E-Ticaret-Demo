using E_TicaretApi.Repositories;
using ETicaretDB.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Controllers
{
    public class KullaniciPanel : Controller
    {
        VwAspnetRoleRepository RoleRepository;
        ETicaretContext db = new ETicaretContext();
        public KullaniciPanel()
        {
            RoleRepository = new VwAspnetRoleRepository();
           
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        //public Task<IActionResult> Index()
        //{

        //}
    }
}
