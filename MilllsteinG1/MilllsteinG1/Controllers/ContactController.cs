using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Models;

namespace MilllsteinG1.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public ActionResult Index()
        {
            ContactModel CM = new ContactModel();
            return View(CM);
        }
        public ActionResult NyCity(int id)
        {
            ContactModel CM = new ContactModel();
            CM.setLocation(id);
            return View(CM);
        }

        public ActionResult WashingtonDCCity(int id)
        {
            ContactModel CM = new ContactModel();
            CM.setLocation(id);
            return View(CM);
        }
    }
}