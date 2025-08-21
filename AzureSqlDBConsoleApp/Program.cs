using Microsoft.EntityFrameworkCore;

namespace AzureSqlDBConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product
            {
                Name = "Sample Product",
                Price = 19.99m
            };
            using (var context = new ProductDbContext())
            {
                // Ensure database is created
                context.Database.EnsureCreated();
                // Add a new product
                context.Products.Add(p);
                context.SaveChanges();
                // Retrieve and display the product
                var product = context.Products.FirstOrDefault();
                if (product != null)
                {
                    Console.WriteLine($"Product ID: {product.ProductID}, Name: {product.Name}, Price: {product.Price}");
                }
                else
                {
                    Console.WriteLine("No products found.");
                }
            }
        }
    }

    public class Product
    {
        public int ProductID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }

    public class ProductDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=dbserver-test-delete.database.windows.net;Initial Catalog=db-test-delete;User ID=venkat;Password=password@123456;Connect Timeout=60;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }
    }
}
