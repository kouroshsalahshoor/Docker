using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MvcApp.Models;
<<<<<<< HEAD
using MvcApp.Repository;
=======
>>>>>>> mvcapp

namespace MvcApp.Controllers
{
    public class HomeController : Controller
    {
<<<<<<< HEAD
        private IRepository repository;
        private string message;
        public HomeController(IRepository repo, IConfiguration config)
        {
            repository = repo;
            message = config["MESSAGE"] ?? "Essential Docker";
        }
        public IActionResult Index()
        {
            ViewBag.Message = message;
            return View(repository.Products);
=======
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
>>>>>>> mvcapp
        }
    }
}
