using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using MilllsteinG1.Models;

namespace MilllsteinG1.Controllers
{
    public class InvestmentController : Controller
    {
        // GET: Investment
        public ActionResult Index()
        {

            InvestmentModel IM = new InvestmentModel();

            return View(IM);
        }
    }
}