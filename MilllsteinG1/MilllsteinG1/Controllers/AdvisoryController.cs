using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Models;


namespace MillsteinG1.Controllers
{
    public class AdvisoryController : Controller
    {
        // GET: Advisory
        public ActionResult Index()
        {
            TeamModel TM = new TeamModel();
            return View(TM);
        }
        public ActionResult Info(int id)
        {
            TeamModel TM = new TeamModel();
            TM.Load(id);
            
            return View(TM);
        }

        public ActionResult LoadTeamMember(int id)
        {
          

            TeamModel TM = new TeamModel();
            TM.Load(id);
            return PartialView(TM);
        }
    }
}