using Microsoft.AspNetCore.Mvc;

namespace WebApplicationSecretsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IConfiguration _config;
        public WeatherForecastController(ILogger<WeatherForecastController> logger, IConfiguration config)
        {
            _logger = logger;
            _config = config;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {

            //string cardNo = _config["Payment:CardNumber"] ?? "No Card Found";
            //System.Console.WriteLine($"Card No from Secret Manager: {cardNo}");

            Payment payment = new Payment();
            _config.GetSection("Payment").Bind(payment);
            //payment = _config.GetValue<Payment>("Payment")??null;

            System.Console.WriteLine($"Card No from Secret Manager: {payment.CardNumber}");
            Console.WriteLine(payment.CardHolderName);
            Console.WriteLine(payment.Cvv);

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
