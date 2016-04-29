﻿using EmotionPlatzi.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EmotionPlatzi.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.WelcomeMessage = "Hola mundo";
            return View();
        }

        // GET: IndexAlt
        public ActionResult IndexAlt()
        {
            var modelo = new Home();
            modelo.WelcomeMessage = "Hola mundo desde el model";

            return View(modelo);
        }
    }
}