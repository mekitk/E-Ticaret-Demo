﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Ticaret.Controllers
{
    public class OdemeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
