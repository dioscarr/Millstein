using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL.Models;
using BLL;

namespace MilllsteinG1.Models
{
    public class InvestmentModel:BaseModel
    {
      
        public Investment InvestmentDetail { get; set; }
        public bool isNewPicture { get; set; }
        public List<Team> teamList { get; set; }

       
        public InvestmentModel() {
            InvestmentDetail = ManageInvestment.GetAllInvestment().FirstOrDefault();
          
        }
        public void LoadAllManagement()
        {
            teamList = ManageTeam.GetAllTeam().Where(u => u.Type == "manage").ToList();
        }
       

    }
}