using Microsoft.AspNetCore.Mvc;

namespace IntroCAPI
{
    [Route("[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello, from the API!";
        }
    }
}
