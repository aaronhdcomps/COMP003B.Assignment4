using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace COMP003B.Assignment4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Form() 
        {
            return View();
        }

        /*[HttpPost]
        public IActionResult Confirm() 
        {
            if (!ModelState.IsValid) 
            {
                return View("Form", model);
            }
        }
        */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}