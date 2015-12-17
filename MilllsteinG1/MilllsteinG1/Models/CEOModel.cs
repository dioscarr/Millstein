using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace MilllsteinG1.Models
{
    public class CEOModel:BaseModel
    {
    
        public CEO CEODetail { get; set; }
       
        public CEOModel()
        {
            CEODetail = ManageCEO.GetAllCEO().FirstOrDefault();
          
        }


    }
}