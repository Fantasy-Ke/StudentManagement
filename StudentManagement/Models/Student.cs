using System.ComponentModel.DataAnnotations;
namespace StudentManagement.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name ="姓名")]
        [Required(ErrorMessage ="请输入姓名")]
        public string Name { get; set; }
        [Display(Name = "班级信息")]
        [Required]
        public ClassNameEnum? ClassName { get; set; }
        [Display(Name ="邮箱")]
        [RegularExpression(@"^[a-zA-Z0-9_-]+@[a-zA-Z0-9_-]+(\.[a-zA-Z0-9_-]+)+$",ErrorMessage ="邮箱格式不正确")]
        [Required(ErrorMessage ="请输入邮箱")]
        public string Email { get; set; }
        [Display(Name="图片")]
        public string PhotoPath { get; set; }
    }
}
