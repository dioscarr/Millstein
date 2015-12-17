using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace MilllsteinG1.Models
{
    public class FirmModel:BaseModel
    {
    
        public Firm FirmDetail { get; set; }
       
        public FirmModel()
        {
            FirmDetail = ManageFirm.GetAllFirm().FirstOrDefault();
          
        }


    }
}