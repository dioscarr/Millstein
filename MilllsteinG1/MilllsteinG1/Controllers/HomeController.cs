﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Models;

namespace Millstein.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            HomeModel HM =  new HomeModel();  
           
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}