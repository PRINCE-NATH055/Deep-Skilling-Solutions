using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace JwtAuthService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {        
        [HttpGet]
        [Authorize]
        public IActionResult Get()
        {
            var data = new[]
            {
                new { Date = DateTime.Now, TemperatureC = 25, Summary = "Sunny" },
                new { Date = DateTime.Now.AddDays(1), TemperatureC = 28, Summary = "Hot" }
            };

            return Ok(data);
        }
    }
}
