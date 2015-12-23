﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace MilllsteinG1.Areas.Admin.Models
{
    public class HomeModel : BaseModel
    {
        public Pages Home { get; set; }
        public List<Slider> SliderList { get; set; }
        public List<News> NewslIST { get; set; }
        public HomeModel()
        {
            Home = ManagePages.GetAllPages().FirstOrDefault();
            SliderList = ManageSlider.GetAllSlider().Where(p => p.HomeId == Home.Id).ToList();
            NewslIST = ManageNews.GetAllNews().OrderBy(c => c.NewsDate).Take(3).ToList(); ;
        }

        internal bool Update(HomeModel model)
        {
            return ManagePages.UpdatePages(model.Home);
        }

    }
}