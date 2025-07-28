using HarmanCoolProductsService.Models.Data;
using HarmanCoolProductsService.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace HarmanCoolProductsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoolProductsController : ControllerBase
    {

        // add action methods - endpoints -  map action methods with HTTP Methods - GET-POST-PUT-DELETE-PATCH
        // 

        // return all products


        // GET www.harman.com/api/
        //  // GET localhost:234234/api/CoolProducts
        [HttpGet]
        public List<Product> GetProducts() // Action Method
        {
            // get products from model/backend/data layer and return
            using (HarmansCoolProductsDbContext db = new Models.Data.HarmansCoolProductsDbContext())
            {
                return db.Products.ToList();
            }
        }

        // get product by id
        //localhost:234234/api/CoolProducts/123
        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetProdcutById(int id)
        {
            using (HarmansCoolProductsDbContext db = new Models.Data.HarmansCoolProductsDbContext())
            {
                var prodductToSearch = db.Products.Find(id);
                if (prodductToSearch != null)
                    return Ok(prodductToSearch); // 200 with data
                else
                    return NotFound(); // 404
            }
        }


        //Lab 1: get product by name
        //localhost:234234/api/CoolProducts/name/smartwatch
        [HttpGet]
        [Route("name/{name:alpha}")]
        public IActionResult GetProductByName(string name)
        {
            using (HarmansCoolProductsDbContext db = new Models.Data.HarmansCoolProductsDbContext())
            {
                var prodductToSearch = db.Products.Where(p => p.Name == name).FirstOrDefault();
                if (prodductToSearch != null)
                    return Ok(prodductToSearch); // 200 with data
                else
                    return NotFound(); // 404
            }
        }


        //Lab 2: get products by country

        //localhost:234234/api/CoolProducts/country/india
        [HttpGet]
        [Route("country/{country:alpha}")]
        public IActionResult GetProductByCountry(string country)
        {
            using (HarmansCoolProductsDbContext db = new Models.Data.HarmansCoolProductsDbContext())
            {
                var prodductToSearch = db.Products.Where(p => p.Country == country).ToList();
                if (prodductToSearch.Count > 0)
                    return Ok(prodductToSearch); // 200 with data
                else
                    return NotFound(); // 404
            }
        }


        //Lab 3: get products by brand
        //Lab 4: get cheapest product
        //Lab 5: get costliest product
        //Lab 6: get products in stock
        //Lab 7: get products bewteen price range (1000 - 5000)
        //Lab 8: get products by category
    }
}
