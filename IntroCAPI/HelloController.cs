using Microsoft.AspNetCore.Mvc;

namespace IntroCAPI
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, from the API!";
        }
    }

    // in order to call this file with a "curl" command use: "curl http://localhost:5000/api/hello"
}
