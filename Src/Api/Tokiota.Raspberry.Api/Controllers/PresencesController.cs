namespace Tokiota.Raspberry.Api.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    public class PresencesController : Controller
    {
        [HttpPost]
        public IActionResult Post()
        {
            // call twitter service
            return this.Ok(new { message = "POST" });
        }
    }
}
