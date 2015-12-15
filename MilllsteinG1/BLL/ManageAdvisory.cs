using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using DAL.Repositories;
using System.ComponentModel;




namespace BLL
{
    public class ManageAdvisory 
    {
        #region Select Methods -- GetAllAdvisory, GetById
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static IList<Advisory> GetAllAdvisory()
        {
            return Manage<Advisory, AdvisoryRepository>.GetAll().Where(n => n.isDeleted == false).OrderByDescending(n => n.Created).ToList();
        }
        public static Advisory GetById(int id)
        {
            return Manage<Advisory, AdvisoryRepository>.GetById(id);
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Advisory GetById(string id)
        {
            return Manage<Advisory, AdvisoryRepository>.GetById(id);
        }
        #endregion

        #region Insert Methods -- AddAdvisory
        public static bool AddAdvisory(Advisory n)
        {
            n.Created = DateTime.Now.Date;
            n.Modified = DateTime.Now.Date;

            return Manage<Advisory, AdvisoryRepository>.Add(n);
        }
        #endregion

        #region Update Methods -- UpdateAdvisory
        public static bool UpdateAdvisory(Advisory n)
        {

            n.Modified = DateTime.Now.Date;

            return Manage<Advisory, AdvisoryRepository>.Update(n);
        }
        #endregion

        #region Delete Methods -- DeleteAdvisory
        public static bool DeleteAdvisory(Advisory n)
        {
            n.isDeleted = true;

            return UpdateAdvisory(n);
        }
        #endregion
    }
}
