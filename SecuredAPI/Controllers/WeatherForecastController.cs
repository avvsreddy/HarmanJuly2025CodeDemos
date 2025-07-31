using Microsoft.AspNetCore.Mvc;
using SecuredAPI.Model.Data;
using SecuredAPI.Model.Entities;

namespace SecuredAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private AppDbContext db = null;

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, AppDbContext db)
        {
            _logger = logger;
            this.db = db;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }

        // post .../weatherforecast/register
        [HttpPost("register")]

        public IActionResult Register(User user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Invalid User Data");
            }
            // validate for duplicate user registration

            db.AppUsers.Add(user);
            db.SaveChanges();

            return Ok(); // return created
        }

        // post .../weatherforecast/login
        [HttpPost("login")]
        public IActionResult Login()
        {
            return Ok();
        }


        [HttpGet("anonymous")]
        public IActionResult UnSecuredEndpoint()
        {
            return Ok("This is for anonymous users users only");
        }

        [HttpGet("user")]
        public IActionResult Secured2Endpoint()
        {
            return Ok("This is for registered users only");
        }

        [HttpGet("admin")]
        public IActionResult Secured3Endpoint()
        {
            return Ok("This is for admin users only");
        }
    }
}
