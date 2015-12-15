using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using DAL.Repositories;
using System.ComponentModel;



namespace BLL
{
   public class ManageInvestment
    {
        #region Select Methods -- GetAllInvestment, GetById
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static IList<Investment> GetAllInvestment()
        {
            return Manage<Investment, InvestmentRepository>.GetAll().Where(n => n.isDeleted == false).ToList();
        }
        public static IList<Investment> GetAllInvestmentOf(string type)
        {
            return Manage<Investment, InvestmentRepository>.GetAll().Where(n => n.isDeleted == false).ToList();
        }

        public static Investment GetById(int id)
        {
            return Manage<Investment, InvestmentRepository>.GetById(id);
        }
     
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Investment GetById(string id)
        {
            return Manage<Investment, InvestmentRepository>.GetById(id);
        }
        #endregion

        #region Insert Methods -- AddInvestment
        public static bool AddInvestment(Investment n)
        {
            n.Created = DateTime.Now.Date;
            n.Modified = DateTime.Now.Date;

            return Manage<Investment, InvestmentRepository>.Add(n);
        }
        #endregion

        #region Update Methods -- UpdateInvestment
        public static bool UpdateInvestment(Investment n)
        {

            n.Modified = DateTime.Now.Date;

            return Manage<Investment, InvestmentRepository>.Update(n);
        }
        #endregion

        #region Delete Methods -- DeleteInvestment
        public static bool DeleteInvestment(Investment n)
        {
            n.isDeleted = true;

            return UpdateInvestment(n);
        }
        #endregion

       
    }
}
