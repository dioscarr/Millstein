using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Areas.Admin.Models;

namespace MilllsteinG1.Areas.Admin.Controllers
{[Authorize]
    public class AdminNewsController : Controller
    {
        // GET: News
        public ActionResult Index(int? id)
        {
             NewsModel NM1 = new NewsModel();
            if (id != null)
            {
                ViewBag.CurrentYear = id;
                NewsModel NM = new NewsModel((int)id);               
                return View(NM);
            }

            return View(NM1);
        }
        //[HttpPost]
        //public ActionResult Index(int year)
        //{
             
        //    return View();
        //}
       [HttpGet]
        public ActionResult Article(int id)
        {
            NewsModel NM = new NewsModel();
            NM.setArticle(id);
            NM.setPersonContact(id);

            return View(NM);
        }
    }
}