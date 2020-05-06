using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Protocols.OpenIdConnect;
using ProductivityTools.Learning.OAuth.Client.Models;
using ProductivityTools.SimpleHttpPostClient;

namespace ProductivityTools.Learning.OAuth.Client.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HttpPostClient client = new HttpPostClient(true);
            client.SetBaseUrl("https://localhost:44346");

            var result1 = client.PostAsync<string>("Test", "Date",null);
            var x = result1.GetAwaiter().GetResult();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public async Task WriteOut()
        {
            var identityToken = await HttpContext.GetTokenAsync(OpenIdConnectParameterNames.IdToken);
            Debug.WriteLine($"Idneitytoken:{identityToken}" );
        }
    }
}
