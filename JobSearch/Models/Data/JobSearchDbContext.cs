using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace JobSearch.Models.Data
{
    public class JobSearchDbContext
    {
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyType> CompanyTypes { get; set; }
    }
}