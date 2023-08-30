using Microsoft.AspNetCore.Mvc;

namespace Api.GestaoEstoque.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }       

        [HttpGet]
        [Route("HealthCheck")]
        public async Task<IActionResult> HealthCheck()
        {
            var data = new { mensagem = "Eu estou online" };
            return Ok(data);
        }
    }    
}