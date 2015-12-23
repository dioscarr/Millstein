using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Areas.Admin.Models;

namespace MilllsteinG1.Areas.Admin.Controllers

{[Authorize]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {


            return View(new HomeModel());
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult Index(HomeModel model)
        {
            var result = model.Update(model);
            return View();
        }

     

    }
}