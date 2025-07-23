using EFDemo1.Data;
using EFDemo1.Entities;

namespace EFDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Manage Products : CRUD

            //User Story: I as a user i want to  Save product details into database table, so that i can get it back

            // Step 1: UI: console, DB: MS Sql Server, FW: EF, Code First
            // STep 2: Create Product Entity class - done
            // Step 3: Download and Install EF Core from nuget - done
            // Step 4: Configure DB and Map Classes with Tables - done
            // STep 5: Data Migration - each time when dbcontext or entity classess changes -> PMC/CLI

            //SaveProduct();
            GetAll();

            //Delete();
            // Update

            //Update();



            // Add new product with new category
            ProductsDbContext db = new ProductsDbContext();
            Product p = new Product { ProductName = "I Phone 16", Price = 99000, Brand = "Apple" };

            Category c = new Category { CategoryName = "Mobiles" };

            p.Category = c;

            db.Products.Add(p);
            //db.Categories.Add(c);
            db.SaveChanges();

        }

        private static void Update()
        {
            ProductsDbContext db = new ProductsDbContext();
            // get the object to edit
            var productToEdit = db.Products.Find(2);
            productToEdit.Price += 1000;
            db.SaveChanges();
        }

        private static void Delete()
        {
            // Delete
            ProductsDbContext db = new ProductsDbContext();
            // Get the object to delete
            var productToDelete = (from p in db.Products
                                   where p.ProductId == 1
                                   select p).FirstOrDefault();
            db.Products.Remove(productToDelete);
            db.SaveChanges();
        }

        private static void GetAll()
        {
            //User Story: I as a user, i want to get all products from database, so that i can display

            ProductsDbContext db = new ProductsDbContext();
            // Linq to Entities
            var allProducts = from p in db.Products
                              select p;

            // display
            foreach (var item in allProducts)
            {
                Console.WriteLine($"{item.ProductId}\t{item.ProductName}\t{item.Price}");
            }
        }

        private static void SaveProduct()
        {
            // Step 6: Save product details into database
            Product p = new Product();
            Console.Write("Enter Product Name: ");
            p.ProductName = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            p.Price = int.Parse(Console.ReadLine());

            ProductsDbContext db = new ProductsDbContext();
            db.Products.Add(p);
            db.SaveChanges();
            Console.WriteLine("Product saved.....");
        }
    }
}
