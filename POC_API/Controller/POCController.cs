using Microsoft.AspNetCore.Mvc;

namespace POC_API.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class POCController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Get the string";
        }
    }
}
