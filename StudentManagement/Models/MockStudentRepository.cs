using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentManagement.Models
{
    public class MockStudentRepository : IStudentRepository
    {
        private List<Student> _students;

        public MockStudentRepository()
        {
            List<Student> students = new List<Student>
        {
            new Student { Id=1, Name="小米", ClassName="红米", Email="hello1@deali.cn" },
            new Student { Id=2, Name="华为", ClassName="荣耀", Email="hello2@deali.cn" },
            new Student { Id=3, Name="oppo", ClassName="vivo", Email="hello3@deali.cn" },
        };
            _students = students;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _students;
        }

        public Student GetById(int id)
        {
            return _students.FirstOrDefault(a => a.Id == id);
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }
    }
}
