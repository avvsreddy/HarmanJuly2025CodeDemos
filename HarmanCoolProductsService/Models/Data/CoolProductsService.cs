using HarmanCoolProductsService.Models.Domain;
using HarmanCoolProductsService.Models.Entities;

namespace HarmanCoolProductsService.Models.Data
{
    public class CoolProductsService : ICoolProductsService
    {

        private HarmansCoolProductsDbContext db = null;

        public CoolProductsService(HarmansCoolProductsDbContext db)
        {
            this.db = db;
        }
        public Product GetProductById(int id)
        {
            return db.Products.Where(p => p.IsDeleted == false && p.Id == id).FirstOrDefault();
        }

        public Product GetProductByName(string name)
        {
            return db.Products.Where(p => p.Name == name && p.IsDeleted == false).FirstOrDefault();
        }

        public List<Product> GetProducts()
        {
            return db.Products.Where(p => p.IsDeleted == false).ToList();
        }

        public List<Product> GetProductsByCountry(string country)
        {
            return db.Products.Where(p => p.Country == country && p.IsDeleted == false).ToList();
        }

        public void SaveProduct(Product product)
        {
            db.Products.Add(product);
            db.SaveChanges();
        }

        public void SoftDeleteProduct(int id)
        {
            var productToSoftDel = GetProductById(id);
            productToSoftDel.IsDeleted = true;
            db.SaveChanges();
        }

        public void UpdateProduct(Product product)
        {
            db.Products.Entry(product).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            db.SaveChanges();
        }
    }
}
