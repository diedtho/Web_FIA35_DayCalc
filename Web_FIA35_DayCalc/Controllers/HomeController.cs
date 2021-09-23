﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web_FIA35_DayCalc.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string inpVorname, DateTime inpGeburtstag)
        {
            ViewBag.Vorname = inpVorname;
            ViewBag.TageSeitGeb = (DateTime.Now - inpGeburtstag).Days;            

            return View();
        }

    }
}
