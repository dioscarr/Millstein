using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Areas.Admin.Models;
using System.IO;

namespace MilllsteinG1.Areas.Admin.Controllers
{
    [ValidateInput(false)]
    public class AdvisorsController : Controller
    {
        public ActionResult Index()
        {
            TeamModel TM = new TeamModel();
            return View(TM);
        }
        [HttpPost]
        [ValidateInput(false)]
        public ActionResult UpdateAdvisorsOverview(TeamModel model)
        {
            try
            {
                model.advisory.Picture = ImageUload(model, "~/Images");
                model.updateAdvisoryOverview(model);
                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                throw;
            }

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


        //upload image
        public string ImageUload(TeamModel model, string url)
        {
            var validImageTypes = new string[]
            {
                "image/gif",
                "image/jpeg",
                "image/jpg",
                "image/pjpeg",
                "image/png"
            };

            if (model.ImageUpload == null || model.ImageUpload.ContentLength == 0)
            {
                ModelState.AddModelError("ImageUpload", "This field is required");
            }
            else if (!validImageTypes.Contains(model.ImageUpload.ContentType))
            {
                ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.");
            }

            if (ModelState.IsValid)
            {
                if (model.ImageUpload != null && model.ImageUpload.ContentLength > 0)
                {
                    var uploadDir = url;
                    var imagePath = Path.Combine(Server.MapPath(uploadDir), model.ImageUpload.FileName);
                    var imageUrl = Path.Combine(uploadDir, model.ImageUpload.FileName);
                    model.ImageUpload.SaveAs(imagePath);
                    return model.ImageUpload.FileName;
                }
            } return "noimg.jpg";



        }

    }
}