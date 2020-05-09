using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RouteAttribute = Microsoft.AspNetCore.Mvc.RouteAttribute;

namespace ProductivityTools.Learning.OAuth.Api2.Controllers
{
    [Route("Identity")]
    public class IdentityController
    {
        [HttpGet("Free")]
        public IActionResult Free()
        {
            return new JsonResult($"free:{DateTime.Now.ToString()}");
        }

        [HttpGet("Paid")]
        //[Authorize]
        public IActionResult Paid()
        {
            return new JsonResult($"Paid: {DateTime.Now.ToString()}");
        }
    }
}
