namespace Tokiota.Raspberry.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class TestController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult Get()
        {
            return this.Ok(new { message = "Test" });
        }
    }
}
