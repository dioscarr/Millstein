using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using System.Data.Entity;


namespace DAL.Repositories
{
    public class InvestmentRepository : GenericRepository<Investment>
    {
        public InvestmentRepository(DbContext db)
            : base(db) {         
        }


    }
}
