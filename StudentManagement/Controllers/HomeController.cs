using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;

namespace StudentManagement.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        public HomeController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public string Index()
        {
            return _studentRepository.GetById(2).Name;
        }
        public IActionResult Deltis()
        {
            ViewBag.Title = "学生视图123";
            ViewData["Model"]= _studentRepository.GetById(2);
            var student = _studentRepository.GetById(2);
            var student1 = 2001;
            return View(student);
        }
    }
}
