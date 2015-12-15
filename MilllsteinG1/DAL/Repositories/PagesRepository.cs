using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using System.Data.Entity;
namespace DAL.Repositories
{
    public class PagesRepository : GenericRepository<Pages>
    {
        public PagesRepository(DbContext db)
            : base(db) { }
    }
}
