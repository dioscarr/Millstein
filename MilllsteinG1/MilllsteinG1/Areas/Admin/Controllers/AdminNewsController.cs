using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Areas.Admin.Models;
using DAL;
using BLL;


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


       [ValidateInput(false)]
       [HttpPost]
       public ActionResult Article(NewsModel model)
       {

           model.Update(model.Article);

           return RedirectToAction("index");
       }



       public ActionResult Action()
       {
           return View();
       }
       [HttpGet]
       public ActionResult Insert()
       {

           
           ViewBag.DropDownListInvestment = InvList;

           NewsModel insertnews = new NewsModel();
           return View(insertnews.Article);
       }
       [ValidateInput(false)]
       [HttpPost]
       public ActionResult Insert(News model, string InvestmentId)
       {
           model.isDeleted = false;
           NewsModel insertnews = new NewsModel();
           insertnews.insert(model);
           return RedirectToAction("index");
       }

       public ActionResult delete(int id)
       {
           News n = ManageNews.GetById(id);
           NewsModel NM = new NewsModel();
           NM.delete(n);
           return RedirectToAction("");
       }
        
    }
}