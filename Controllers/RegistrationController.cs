using Microsoft.AspNetCore.Mvc;
using WebApplication_DotNet.Models;

namespace WebApplication_DotNet.Controllers
{
    public class RegistrationController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Student student)
        {
            if (!ModelState.IsValid)
            {
                return View(student);
            }
            ViewBag.Message = "Registration Successful" + student.Name;
            return View("Success",student);
        }
    }
}
