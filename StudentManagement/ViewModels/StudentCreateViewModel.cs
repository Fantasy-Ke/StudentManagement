using Microsoft.AspNetCore.Http;
using StudentManagement.Models;
using System.Collections.Generic;

namespace StudentManagement.ViewModels
{
    public class StudentCreateViewModel:Student
    {
        public  IFormFile Photo { get; set; }
        public List<IFormFile> Photos { get; set; }
    }
}
