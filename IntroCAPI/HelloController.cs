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
}
