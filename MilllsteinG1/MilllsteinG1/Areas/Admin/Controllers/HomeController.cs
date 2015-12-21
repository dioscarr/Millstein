using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MilllsteinG1.Areas.Admin.Models;

namespace MilllsteinG1.Areas.Admin.Controllers

{[Authorize]
    public class HomeController : Controller
    {
        // GET: Admin/Home
        public ActionResult Index()
        {


            return View(new ImageViewModel());
        }

    [HttpPost]
[ValidateAntiForgeryToken]
public ActionResult Index(ImageViewModel model)
{
    //var validImageTypes = new string[]
    //{
    //    "image/gif",
    //    "image/jpeg",
    //    "image/pjpeg",
    //    "image/png"
    //};

    //if (model.ImageUpload == null || model.ImageUpload.ContentLength == 0)
    //{
    //    ModelState.AddModelError("ImageUpload", "This field is required");
    //}
    //else if (!imageTypes.Contains(model.ImageUpload.ContentType))
    //{
    //    ModelState.AddModelError("ImageUpload", "Please choose either a GIF, JPG or PNG image.
    //}

    //if (ModelState.IsValid)
    //{
    //    var image = new Image
    //    {C:\Users\Clever Design\Desktop\Work\DisocarRodriguez\MVC-Project\MillsteinGithub\MilllsteinG1\MilllsteinG1\Areas\Admin\Controllers\AdvisorsController.cs
    //        Title = model.Title,
    //        AltText = model.AltText,
    //        Caption = model.Caption
    //    }

    //    if (model.ImageUpload != null && model.ImageUpload.ContentLength > 0)
    //    {
    //        var uploadDir = "~/uploads"
    //        var imagePath = Path.Combine(Server.MapPath(uploadDir), model.ImageUpload.FileName);
    //        var imageUrl = Path.Combine(uploadDir, model.ImageUpload.FileName);
    //        model.ImageUpload.SaveAs(imagePath);
    //        image.ImageUrl = imageUrl;
    //    }

    //    db.Create(image);
    //    db.SaveChanges();
    //    return RedirectToAction("Index");
    //}

    return View(model);
}

     

    }
}