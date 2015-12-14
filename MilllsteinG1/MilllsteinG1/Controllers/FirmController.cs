using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Millstein.Controllers
{
    public class FirmController : Controller
    {
        // GET: Firm
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Ceo()
        {
            return View();
        }
    }
}