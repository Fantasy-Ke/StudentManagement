using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.ViewModels;

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
            HomeDetailViewModel homeDetailsViewModel = new HomeDetailViewModel()
            {
                Student = _studentRepository.GetById(2),
                PageTitle="学生试图"
            };
            return View(homeDetailsViewModel);
        }
    }
}
