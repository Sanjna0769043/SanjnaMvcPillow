using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SanjnaMvcPillow.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace SanjnaMvcPillow.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()    // view page of home page
        {
            return View();
        }
        public IActionResult Products()  // view page of products
        {
            return View();
        }
        public IActionResult ContactUs()   // view page of contact page
        {
            return View();
        }

        public IActionResult Privacy()   // view page of Privacy policy
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
