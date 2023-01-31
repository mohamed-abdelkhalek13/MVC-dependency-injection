using Microsoft.AspNetCore.Mvc;
using MVC2.Models;
using System.Diagnostics;
using MVC2.Models;

namespace MVC2.Controllers
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

        

    }
}