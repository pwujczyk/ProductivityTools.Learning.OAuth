using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ProductivityTools.Learning.OAuth.MvcClient.Views.Home
{
    public class SignOutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}