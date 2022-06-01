using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BasicApiController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<BasicApiController> _logger;

        public BasicApiController(ILogger<BasicApiController> logger)
        {
            _logger = logger;
        }


        [HttpGet(Name = "TrueString")]
        public String TrueString()
        {
            return bool.TrueString;
        }

        [HttpGet(Name = "FalseString")]
        public String FalseString()
        {
            return bool.FalseString;
        }

        [HttpGet(Name = "One")]
        public String One()
        {
            return "1";
        }

        [HttpGet(Name = "Two")]
        public String Two()
        {
            return "2";
        }

        [HttpGet(Name = "Three")]
        public String Three()
        {
            return "3";
        }
    }
}
