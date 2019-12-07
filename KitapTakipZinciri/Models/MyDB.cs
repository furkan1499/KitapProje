using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace KitapTakipZinciri.Models
{
    public class MyDB:DbContext
    {
        public MyDB() : base(@"Data Source=DESKTOP-IQHUI0O\SQLEXPRESS;Initial Catalog=MyDB;Integrated Security=True")
        {

        }
        public DbSet<author> authors { get; set; }
        public DbSet<book> books { get; set; }
        public DbSet<paperCompany> paperCompanies { get; set; }
        public DbSet<transportationCompany> transportationCompanies { get; set; }
        public DbSet<admin> admins { get; set; }
        public DbSet<route> route { get; set; }
        public DbSet<treeCutCompany> treeCutCompanies { get; set; }



    }
}
