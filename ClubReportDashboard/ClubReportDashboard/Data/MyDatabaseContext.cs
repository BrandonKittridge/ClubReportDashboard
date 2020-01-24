using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClubReportDashboard.Models
{
    public class MyDatabaseContext : DbContext
    {
        public MyDatabaseContext(DbContextOptions<MyDatabaseContext> options)
            : base(options)
        {
        }

        private DbSet<ClubReportDashboard.Models.ErrorViewModel> test;

        public DbSet<ClubReportDashboard.Models.ErrorViewModel> GetTest()
        {
            return test;
        }

        public void SetTest(DbSet<ClubReportDashboard.Models.ErrorViewModel> value)
        {
            test = value;
        }
    }
}