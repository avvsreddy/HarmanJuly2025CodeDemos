using HarmanCoolProductsService.Models.Entities;

namespace HarmanCoolProductsService.Models.Domain
{
    public interface ICoolProductsService
    {
        List<Product> GetProducts();
        Product GetProductById(int id);
        Product GetProductByName(string name);
        List<Product> GetProductsByCountry(string country);
        void UpdateProduct(Product product);
        void SoftDeleteProduct(int id);
        void SaveProduct(Product product);
    }
}
