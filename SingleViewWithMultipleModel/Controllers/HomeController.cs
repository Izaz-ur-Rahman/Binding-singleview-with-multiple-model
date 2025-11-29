using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SingleViewWithMultipleModel.Models;

namespace SingleViewWithMultipleModel.Controllers
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
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "John Doe",Gender"Male", Standard=10 },
                new Student { Id = 2, Name = "Noor",Gender"Female", Standard=10 },
                new Student { Id = 3, Name = "John Doe",Gender"Male", Standard=10 },
                new Student { Id = 4, Name = "John Doe",Gender"Male", Standard=10 },
                new Student { Id = 5, Name = "John Doe",Gender"Male", Standard=10 }
      
            };
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
    }
}
