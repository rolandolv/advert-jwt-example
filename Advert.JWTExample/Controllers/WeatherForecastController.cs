using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Advert.JWTExample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]
        [Authorize]
        [EnableCors("Default")]
        public ActionResult<string> Get()
        {
            return "Hello";
        }
    }
}
