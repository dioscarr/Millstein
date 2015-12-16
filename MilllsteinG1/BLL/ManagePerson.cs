using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using DAL.Repositories;
using System.ComponentModel;




namespace BLL
{
    public class ManagePerson 
    {
        #region Select Methods -- GetAllPerson, GetById
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static IList<Person_> GetAllPerson()
        {
            return Manage<Person_, PersonRepository>.GetAll().Where(n => n.isDeleted == false).OrderByDescending(n => n.Created).ToList();
        }
        public static Person_ GetById(int id)
        {
            return Manage<Person_, PersonRepository>.GetById(id);
        }
        [DataObjectMethod(DataObjectMethodType.Select)]
        public static Person_ GetById(string id)
        {
            return Manage<Person_, PersonRepository>.GetById(id);
        }
        #endregion

        #region Insert Methods -- AddPerson
        public static bool AddPerson(Person_ n)
        {
            n.Created = DateTime.Now.Date;
            n.Modified = DateTime.Now.Date;

            return Manage<Person_, PersonRepository>.Add(n);
        }
        #endregion

        #region Update Methods -- UpdatePerson
        public static bool UpdatePerson(Person_ n)
        {

            n.Modified = DateTime.Now.Date;

            return Manage<Person_, PersonRepository>.Update(n);
        }
        #endregion

        #region Delete Methods -- DeletePerson
        public static bool DeletePerson(Person_ n)
        {
            n.isDeleted = true;

            return UpdatePerson(n);
        }
        #endregion
    }
}
