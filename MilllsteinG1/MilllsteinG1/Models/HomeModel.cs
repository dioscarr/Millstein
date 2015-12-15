using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MilllsteinG1.Models;
using DAL.Models;
using BLL;


namespace MilllsteinG1.Models
{
    public class HomeModel:BaseModel
    {
        public Pages Home { get; set;}
       // public List<Slider> SliderList { get; set;}
    
        public HomeModel()
        {
            Home = ManagePages.GetAllPages().FirstOrDefault();
          //  advisory = ManageAdvisory.GetAllAdvisory().FirstOrDefault();
          //  news = null;
        }
       
    }
}