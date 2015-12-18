using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MilllsteinG1.Models
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult TermsAndConditions()
        {
            return View();
        }
    }
}