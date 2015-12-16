using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilllsteinG1.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string year)
        {
             
            return View();
        }
       
        public ActionResult Article()
        {
            return View();
        }
    }
}