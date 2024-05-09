using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVCDHProject.Models
{
    public class MVCCoreDbContext : IdentityDbContext
    {
        public MVCCoreDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Customer> Customers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Customer>().HasData(
               new Customer { Custid = 101, Name = "Sai", Balance = 50000.00m, City = "Delhi", Status = true },
               new Customer { Custid = 102, Name = "Sonia", Balance = 40000.00m, City = "Mumbai", Status = true },
               new Customer { Custid = 103, Name = "Pankaj", Balance = 30000.00m, City = "Chennai", Status = true },
               new Customer { Custid = 104, Name = "Samuels", Balance = 25000.00m, City = "Bengaluru", Status = true }
           );
        }


    }

}
