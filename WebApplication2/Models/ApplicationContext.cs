using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options) 
        {
        
        
        }

      public DbSet<tbl_location> tbl_Locations { get; set; }
      public DbSet<location_Concatenate> tbl_LocConcate { get; set; }
        public DbSet<EmployeeViewModel> tbl_BindDropDown { get; set; }

      //  public DbSet<Category> tbl_Category { get; set; }
      //public DbSet<SubCategory> tbl_SubCategory { get; set; }
      //public DbSet<MainProduct> tbl_MainProduct { get; set; }

    }
}

