﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilllsteinG1.Areas.Admin.Controllers
{

    [Authorize]
    public class AdminController : Controller
    {
        // GET: Admin/Admin
        public ActionResult Index()
        {
            return View();
        }
    }
}