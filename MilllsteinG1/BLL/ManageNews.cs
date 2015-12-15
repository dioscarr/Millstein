using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using DAL.Repositories;
using System.ComponentModel;

namespace BLL
{
    public class ManageNews
    {
        #region Select Methods -- GetAllNews, GetById
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static IList<News> GetAllNews()
        {
            return Manage<News, NewsRepository>.GetAll().Where(n => n.isDeleted == false).OrderByDescending(n => n.NewsDate).ToList();
        }
        public static News GetById(int id)
        {
            return Manage<News, NewsRepository>.GetById(id);
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static News GetById(string id)
        {
            return Manage<News, NewsRepository>.GetById(id);
        }
        #endregion

        #region Insert Methods -- AddNews
        public static bool AddNews(News n)
        {
            n.Created = DateTime.Now.Date;
            n.Modified = DateTime.Now.Date;

            return Manage<News, NewsRepository>.Add(n);
        }
        #endregion

        #region Update Methods -- UpdateNews
        public static bool UpdateNews(News n)
        {
            n.Modified = DateTime.Now.Date;

            return Manage<News, NewsRepository>.Update(n);
        }
        #endregion

        #region Delete Methods -- DeleteNews
        public static bool DeleteNews(News n)
        {
            n.isDeleted = true;


           
            return UpdateNews(n);
        }
        #endregion
    }
}
