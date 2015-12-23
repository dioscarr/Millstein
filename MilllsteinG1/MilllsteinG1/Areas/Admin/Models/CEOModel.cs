﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace MilllsteinG1.Areas.Admin.Models
{
    public class CEOModel : BaseModel
    {

        public CEO CEODetail { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }
        public bool isNewPicture { get; set; }

        public CEOModel()
        {
            CEODetail = ManageCEO.GetAllCEO().FirstOrDefault();

        }

        public bool Update(CEOModel model)
        {
            return ManageCEO.UpdateCEO(model.CEODetail);
        }


    }
}