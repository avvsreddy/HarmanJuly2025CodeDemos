using EFDemo1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFDemo1.Data
{
    public class ProductsDbContext : DbContext
    {
        // Configure Database



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=HarmanProductsDbJuly2025;Trusted_Connection=True;");
        }



        // Map Entities with Tables
        public DbSet<Product> Products { get; set; }

    }
}
