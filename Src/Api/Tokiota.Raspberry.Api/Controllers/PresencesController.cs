using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tokiota.Raspberry.Api.Controllers
{
    [Route("api/[controller]")]
    public class PrecencesController : Controller
    {
        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
            // call twitter service
        }
    }
}
