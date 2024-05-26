using Child_Parenting_for_Special_Children.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Child_Parenting_for_Special_Children.Controllers
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

        public IActionResult Therapist()
        {
            return View();
        }
        public IActionResult Education()
        {
            return View();
        }
        public IActionResult Support()
        {
            return View();
        }
        public IActionResult Contact()
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
