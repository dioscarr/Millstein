using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using DAL.Repositories;
using System.ComponentModel;




namespace BLL
{
    public class ManageCEO 
    {
        #region Select Methods -- GetAllCEO, GetById
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static IList<CEO> GetAllCEO()
        {
            return Manage<CEO, CEORepository>.GetAll().Where(n => n.isDeleted == false).OrderByDescending(n => n.Created).ToList();
        }
        public static CEO GetById(int id)
        {
            return Manage<CEO, CEORepository>.GetById(id);
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static CEO GetById(string id)
        {
            return Manage<CEO, CEORepository>.GetById(id);
        }
        #endregion

        #region Insert Methods -- AddCEO
        public static bool AddCEO(CEO n)
        {
            n.Created = DateTime.Now.Date;
            n.Modified = DateTime.Now.Date;

            return Manage<CEO, CEORepository>.Add(n);
        }
        #endregion

        #region Update Methods -- UpdateCEO
        public static bool UpdateCEO(CEO n)
        {

            n.Modified = DateTime.Now.Date;

            return Manage<CEO, CEORepository>.Update(n);
        }
        #endregion

        #region Delete Methods -- DeleteCEO
        public static bool DeleteCEO(CEO n)
        {
            n.isDeleted = true;

            return UpdateCEO(n);
        }
        #endregion
    }
}
