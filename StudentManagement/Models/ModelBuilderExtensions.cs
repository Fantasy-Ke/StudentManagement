using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<Student>().HasData(
               new Student { Id = 1, Name = "小米", ClassName = ClassNameEnum.FirstGrade, Email = "hello1@deali.cn" },
               new Student { Id = 2, Name = "华为", ClassName = ClassNameEnum.SecondGrade, Email = "hello2@deali.cn" }
               );
        }
    }
}
