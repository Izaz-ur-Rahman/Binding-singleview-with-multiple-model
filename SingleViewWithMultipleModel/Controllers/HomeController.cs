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
                new Student { Id = 1, Name = "John Doe",Gender="Male", Standard=10 },
                new Student { Id = 2, Name = "Noor",Gender="Female", Standard=4 },
                new Student { Id = 3, Name = "Izaz",Gender="Male", Standard=9 },
                new Student { Id = 4, Name = "Hakim",Gender="Male", Standard=11 },
                new Student { Id = 5, Name = "Anees",Gender="Male", Standard=12 }
      
            };
            List<Teacher> teachers = new List<Teacher>
            {
                //new Teacher { Id = 1, Name = "John Doe",Qualification = "M.A Islamyat",Salary = 100000 },
                //new Teacher { Id = 2, Name = "Noor",Qualification = "ACCA",Salary = 100000},
                //new Teacher { Id = 3, Name = "Izaz",Qualification = "MSC",Salary = 100000 },
                //new Teacher { Id = 4, Name = "Hakim",Qualification = "CS",Salary = 100000 },
                //new Teacher { Id = 5, Name = "Anees",Qualification = "BBA",Salary = 100000 }

            };
            SchoolViewModelcs obj = new SchoolViewModelcs()
            {
                Mystudents = students,
                Myteachers = teachers
            };
            return View(obj);
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
