using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Areas.Admin.Models;

namespace MilllsteinG1.Areas.Admin.Controllers
{
    public class AdminFirmController : Controller
    {
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