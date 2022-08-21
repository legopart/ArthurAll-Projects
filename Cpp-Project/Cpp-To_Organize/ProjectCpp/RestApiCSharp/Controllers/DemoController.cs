using Microsoft.AspNetCore.Mvc;

namespace RestApiCs.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DemoController : ControllerBase
    {

        private readonly ILogger<DemoController> _logger;

        public DemoController(ILogger<DemoController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get(int aaa)
        {
            return $"got {aaa} sec";
        }


    }
}