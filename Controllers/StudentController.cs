using Microsoft.AspNetCore.Mvc;
namespace FirstMVCApp.Controllers
{
    public class StudentController:Controller
    {
        public IActionResult Index()
        {
            ViewBag.Title = "Student List";
            ViewData["SubTitle"] = "Enrolled student this Semester";

            var student = new List<string>
            {
                "Alice Rahman", "Bob Hasan", "Carol Akter", "David Khan"
            };
            return View(student);
        }
        public IActionResult Details(int id)
        {
            ViewBag.StudentId = id;
            return View();
        }

        public IActionResult About()
        {
            return Content("This is the Student module.");
        }
    }
}