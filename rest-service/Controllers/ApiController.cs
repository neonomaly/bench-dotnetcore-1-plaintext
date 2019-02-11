using Microsoft.AspNetCore.Mvc;

namespace rest_service.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string> Get([FromQuery(Name = "my-name")] string name)
        {
            return name == null ? "Please, setup query parameter \"my-name\"" : $"Hello, {name}!";
        }

    }
}