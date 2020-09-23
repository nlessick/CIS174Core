using CIS174_CoreApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace CIS174_CoreApp.Controllers
{
    public class HomeController : Controller
    {

        [Route("[action]")]
        public IActionResult About()
        {
            return View();
        }
        private StudentContext context { get; set; }

        public HomeController(StudentContext ctx)
        {
            context = ctx;
        }

        public IActionResult Index()
        {
            var students = context.Students.OrderBy(s => s.FirstName).ToList();
            return View(students);
        }
    }
}
