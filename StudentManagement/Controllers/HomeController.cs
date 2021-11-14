using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using StudentManagement.Models;
using StudentManagement.ViewModels;
using System;
using System.IO;

namespace StudentManagement.Controllers
{

    public class HomeController : Controller
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IWebHostEnvironment _webHostEnvironment;

        public HomeController(IStudentRepository studentRepository,IWebHostEnvironment webHostEnvironment)
        {
            _studentRepository = studentRepository;
            _webHostEnvironment = webHostEnvironment;
        }
        /// <summary>
        /// 学生列表
        /// </summary>
        /// <returns></returns>
        public IActionResult Index()
        {
            var studentList = _studentRepository.GetAllStudents();
            return View(studentList);
        }
        /// <summary>
        /// 详细信息
        /// </summary>
        /// <returns></returns>
        public IActionResult Deltis(int? id)
        {
            HomeDetailViewModel homeDetailsViewModel = new HomeDetailViewModel()
            {
                Student = _studentRepository.GetById(id ?? 1),
                PageTitle = "学生试图"
            };
            return View(homeDetailsViewModel);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IActionResult Delete(int id)
        {
            _studentRepository.Delete(id);
            return RedirectToAction("Index", new { id });
        }
        /// <summary>
        /// 创建
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Create(StudentCreateViewModel student)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = string.Empty;
                if (student.Photos != null && student.Photos.Count>0)
                {
                    foreach (var item in student.Photos)
                    {
                        string uploadFolder = Path.Combine(_webHostEnvironment.WebRootPath, "img","arrts");
                        uniqueFileName = Guid.NewGuid() + "_" + item.FileName;

                        string filePath = Path.Combine(uploadFolder, uniqueFileName);
                        item.CopyTo(new FileStream(filePath, FileMode.Create));
                    }
                    
                }
                student.PhotoPath = uniqueFileName;
                _studentRepository.Create(student);

                return RedirectToAction("Deltis", new { student.Id });
            }
            return View();
        }
        /// <summary>
        /// 编辑
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Student student=_studentRepository.GetById(id);
            if (student!=null)
            {
                StudentEditModelView editModelView = new StudentEditModelView
                {
                    Id = student.Id,
                    Name = student.Name,
                    ClassName = student.ClassName,
                    EditPhotoPath = student.PhotoPath,
                    Email = student.Email
                };
                return View(editModelView);
            }
            throw new Exception("查询不到这个信息");
            
        }
    }
}
