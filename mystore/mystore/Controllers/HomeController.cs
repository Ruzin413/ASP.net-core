using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using mystore.Models;

namespace mystore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        //[Route("/")]
        //[Route("[H]/[action]")]
        public IActionResult Index()
        {
            return View();
        }

        //[Route("[h]/[Privacy1]")]
        public IActionResult Privacy()
        {
            return View();
        }
        [Route("Detail/{id}")]
        public int Detail(int id)
        {
            return id;
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
