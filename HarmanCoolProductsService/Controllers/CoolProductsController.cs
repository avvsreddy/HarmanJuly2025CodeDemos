using HarmanCoolProductsService.Models.Data;
using HarmanCoolProductsService.Models.Entities;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace HarmanCoolProductsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CoolProductsController : ControllerBase
    {

        private HarmansCoolProductsDbContext db = new Models.Data.HarmansCoolProductsDbContext(); //DIP

        // add action methods - endpoints -  map action methods with HTTP Methods - GET-POST-PUT-DELETE-PATCH
        // 

        // return all products


        // GET www.harman.com/api/
        //  // GET localhost:234234/api/CoolProducts
        [HttpGet]
        [EnableQuery]
        public IQueryable<Product> GetProducts() // Action Method
        {
            // get products from model/backend/data layer and return
            //using (HarmansCoolProductsDbContext db = new Models.Data.HarmansCoolProductsDbContext())
            //{
            return db.Products.AsQueryable();
            //}
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

        // 2:45PM
        //Lab 3: get products by brand
        //Lab 4: get cheapest product
        //Lab 5: get costliest product
        //Lab 6: get products in stock
        //Lab 7: get products bewteen price range (1000 - 5000)
        //Lab 8: get products by category


        // insert new product data
        // POST localhost:234234/api/CoolProducts
        [HttpPost]
        //[Route("insert")]
        public IActionResult PostProduct(Product product)
        {
            // Validate the input
            if (ModelState.IsValid == false)
            {
                return BadRequest("Invalid Input"); // 400
            }

            // save data
            db.Products.Add(product);
            db.SaveChanges();

            // return http status code 201 + location + data
            return Created($"api/coolproducts/{product.Id}", product);

        }

        // purpose: delete a resource
        // design uri: .../api/coolproducts/123
        // map the route
        [Route("{id:int}")]
        // map the http action
        //[HttpDelete("{id}")]
        [HttpDelete]
        // implement the action method
        public IActionResult DeleteProduct(int id)
        {
            var productToDel = db.Products.Find(id);
            if (productToDel == null)
            {
                return NotFound("Product not found");
            }
            db.Products.Remove(productToDel);
            db.SaveChanges();
            return Ok();

        }

        // purpose: edit product
        // design the uri:
        // map the route
        // map the http action
        // implement the action method

    }




}
