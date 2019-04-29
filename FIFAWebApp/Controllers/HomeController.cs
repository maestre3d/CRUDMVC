﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FIFAWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Search()
        {
            ViewBag.Message = "Muerto";
            return View();
        }

        public ActionResult Players()
        {
            return View();
        }

        public ActionResult Teams()
        {
            return View();
        }
    }
}