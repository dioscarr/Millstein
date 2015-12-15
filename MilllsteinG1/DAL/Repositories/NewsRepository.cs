﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.Models;
using System.Data.Entity;

namespace DAL.Repositories
{
    public class NewsRepository : GenericRepository<News>
    {
        public NewsRepository(DbContext db)
            : base(db)
        {

        }
    }
}
