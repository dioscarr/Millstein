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
       // public List<Investment> UpdateAllInvestments { get; set;}
        public Investment InvestmentDetail { get; set; }
       // public IList<Investment> InvestmentList { get; set; }
       // public IList<Investment> ExiteInvestmentList { get; set; }

       
        public InvestmentModel() {
            InvestmentDetail = ManageInvestment.GetAllInvestment().FirstOrDefault();
          
        }

        //public IList<Investment> getAllInvestmentOf(string type)
        //{
        //    return ManageInvestment.GetAllInvestmentOf(type);
        //}

        //public Investment getInvestmentDetail(int id)
        //{
        //    return ManageInvestment.GetById(id);
        
        //}

    }
}