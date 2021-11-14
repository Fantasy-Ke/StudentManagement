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
        /// <summary>
        /// 学生列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var studentList= _studentRepository.GetAllStudents();
            return View(studentList) ;
        }
        /// <summary>
        /// 详细信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Deltis(int id)
        {
            HomeDetailViewModel homeDetailsViewModel = new HomeDetailViewModel()
            {
                Student = _studentRepository.GetById(id),
                PageTitle="学生试图"
            };
            return View(homeDetailsViewModel);
        }
    }
}
