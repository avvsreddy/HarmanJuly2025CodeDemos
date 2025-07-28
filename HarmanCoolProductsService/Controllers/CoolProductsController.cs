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
    }
}
