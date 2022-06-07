using System;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using System.Text.Json.Nodes;

namespace ModernWebAppNET.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MysfitsController : ControllerBase
    {
        // GET api/mysfits
        [HttpGet]
        public IActionResult Get()
        {

                using (StreamReader r = new StreamReader("./mysfits-response.json"))
                {         
                    var json = r.ReadToEnd();
                    return new JsonResult(JsonObject.Parse(json));
                }  
        }

    }
}
