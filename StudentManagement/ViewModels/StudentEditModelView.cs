using Microsoft.AspNetCore.Http;
using StudentManagement.Models;
using System.Collections.Generic;

namespace StudentManagement.ViewModels
{
    public class StudentEditModelView:Student
    {
        public  List<IFormFile> Photos { get; set; }
        public string EditPhotoPath { get; set; }
    }
}
