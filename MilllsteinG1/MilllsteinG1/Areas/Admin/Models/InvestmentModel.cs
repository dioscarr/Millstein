﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace MilllsteinG1.Areas.Admin.Models
{
    public class InvestmentModel : BaseModel
    {

        public Investment InvestmentDetail { get; set; }
        public bool isNewPicture { get; set; }
        public HttpPostedFileBase ImageUpload { get; set; }



        public InvestmentModel()
        {
            InvestmentDetail = ManageInvestment.GetAllInvestment().FirstOrDefault();

        }

        public bool update(InvestmentModel model)
        {
            return ManageInvestment.UpdateInvestment(model.InvestmentDetail);
        }

    }
}