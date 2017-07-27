﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Tokiota.Raspberry.Api.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        // GET api/values
        [HttpGet]
        public IActionResult  Hello()
        {
            return this.Ok(new { message = "Hello" });
        }
    }
}