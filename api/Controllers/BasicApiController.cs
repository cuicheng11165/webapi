using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("basicApi")]
    public class BasicApiController : ControllerBase
    {
        [HttpGet("TrueString",Name = "TrueString")]
        public String TrueString()
        {
            return bool.TrueString;
        }

        [HttpGet("FalseString",Name = "FalseString")]
        public String FalseString()
        {
            return bool.FalseString;
        }

        [HttpGet("One",Name = "One")]
        public String One()
        {
            return "1";
        }

        [HttpGet("Two",Name = "Two")]
        public String Two()
        {
            return "2";
        }

        [HttpGet("Three",Name = "Three")]
        public String Three()
        {
            return "3";
        }

        [HttpPost("TestPost",Name = "TestPost")]
        public bool TestPost(String a, String b)
        {
            return true;

        }
    }
}
