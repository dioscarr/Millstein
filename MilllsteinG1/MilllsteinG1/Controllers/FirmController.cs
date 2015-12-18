using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Models;
namespace MillsteinG1.Controllers
{
    public class FirmController : Controller
    {
        // GET: Firm
        public ActionResult Index()
        {
            FirmModel FM = new FirmModel();

            return View(FM);
        }
        public ActionResult Ceo()
        {
            CEOModel CM = new CEOModel();

            return View(CM);
        }
    }
}