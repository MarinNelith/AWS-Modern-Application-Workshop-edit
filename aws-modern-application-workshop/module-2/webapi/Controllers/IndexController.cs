using Microsoft.AspNetCore.Mvc;

namespace ModernWebAppNET.Controllers
{
    [Route("/")]
    [ApiController]
    public class IndexController : ControllerBase
    {
        // GET /
        // Used for NLB HealthCheck
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }

    }
}
