using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using DAL.Repositories;
using System.ComponentModel;


namespace BLL
{
   public class ManagePages
    {
        #region Select Methods -- GetAllPages, GetById
        [DataObjectMethod(DataObjectMethodType.Select)]
       public static IList<Pages> GetAllPages()
        {
            return Manage<Pages, PagesRepository>.GetAll().ToList();
        }
        public static Pages GetById(int id)
        {
            return Manage<Pages, PagesRepository>.GetById(id);
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Pages GetById(string id)
        {
            return Manage<Pages, PagesRepository>.GetById(id);
        }
        #endregion

        #region Insert Methods -- AddPages
        public static bool AddPages(Pages n)
        {
            n.Created = DateTime.Now.Date;
            n.Modified = DateTime.Now.Date;

            return Manage<Pages, PagesRepository>.Add(n);
        }
        #endregion

        #region Update Methods -- UpdatePages
        public static bool UpdatePages(Pages n)
        {

            n.Modified = DateTime.Now.Date;

            return Manage<Pages, PagesRepository>.Update(n);
        }
        #endregion

        #region Delete Methods -- DeletePages
        public static bool DeletePages(Pages n)
        {
            n.isDeleted = true;

            return UpdatePages(n);
        }
        #endregion
    }
}
