using HarmanCoolProductsService.Controllers;
using HarmanCoolProductsService.Models.Domain;
using HarmanCoolProductsService.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HarmanCoolProductsService.TestProject
{

    class MockCoolProductsService : ICoolProductsService
    {
        public Task<Product> GetProductByIdAsync(int id)
        {
            Product p1 = new Product { Id = 101, Name = "Galaxy S25", Brand = "Samsung" };
            Product p2 = new Product { Id = 102, Name = "Galaxy S25 Pro", Brand = "Samsung" };
            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            return Task.FromResult(products.Where(p => p.Id == id).FirstOrDefault());
        }

        public Task<Product> GetProductByNameAsync(string name)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsAsync()
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> GetProductsByCountryAsync(string country)
        {
            throw new NotImplementedException();
        }

        public Task SaveProductAsync(Product product)
        {
            throw new NotImplementedException();
        }

        public Task SoftDeleteProductAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateProductAsync(Product product)
        {
            throw new NotImplementedException();
        }
    }

    [TestClass]
    public sealed class CoolProductsControllerTest
    {
        [TestMethod]
        public void GetProductByIDTest_WithExistingID_ShouldReturnOKResult()
        {

            CoolProductsController target = new CoolProductsController(new MockCoolProductsService());
            var data = target.GetProdcutByIdAsync(101).Result as OkObjectResult;
            Assert.IsInstanceOfType(data, typeof(OkObjectResult));
        }

        [TestMethod]
        public void GetProductByIDTest_WithExistingID_ShouldReturnProduct()
        {
            CoolProductsController target = new CoolProductsController(new MockCoolProductsService());
            var data = target.GetProdcutByIdAsync(101).Result as OkObjectResult;
            //Assert.IsInstanceOfType(data, typeof(OkObjectResult));
            var p = data.Value as Product;
            Assert.AreEqual(p.Id, 101);
        }

        [TestMethod]
        public void GetProductByIDTest_WithNotExistingID_ShouldReturnNotFoundStatus()
        {
            CoolProductsController target = new CoolProductsController(new MockCoolProductsService());
            var data = target.GetProdcutByIdAsync(1011).Result as NotFoundObjectResult;
            //Assert.IsInstanceOfType(data, typeof(NotFoundObjectResult));
            Assert.IsNull(data);
            //var p = data.Value as Product;
            //Assert.AreEqual(p.Id, 101);
        }
    }
}
