using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using LayeredArchitectureExample.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace LayeredArchitectureExample.DataAccess.Concrete.EntityFramework
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=DESKTOP-49EA4BS;Database=Northwind;Trusted_Connection=true");
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Northwind;User Id=sa;Password=Ujpdxts2$d!38;"); //docker
        }

        //Veri tabanındaki hangi tablonun hangi modele karşılık geldiğinin belirtildiği yer
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories{ get; set; }
        public DbSet<Customer> Customers{ get; set; }

    }
}
