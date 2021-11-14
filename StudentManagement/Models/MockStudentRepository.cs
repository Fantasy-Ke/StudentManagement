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
            new Student { Id=1, Name="小米", ClassName=ClassNameEnum.FirstGrade, Email="hello1@deali.cn" },
            new Student { Id=2, Name="华为", ClassName=ClassNameEnum.SecondGrade, Email="hello2@deali.cn" },
            new Student { Id=3, Name="oppo",ClassName=ClassNameEnum.GradeThree, Email="hello3@deali.cn" },
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

        public Student Update(Student updatestudent)
        {
            Student student = _students.FirstOrDefault(x => x.Id == updatestudent.Id);
            if (student != null)
            {
                student.Name = updatestudent.Name;
                student.ClassName = updatestudent.ClassName;
                student.Email = updatestudent.Email;
            }
            return student;
        }
        public Student Create(Student student)
        {
            student.Id = _students.Max(x => x.Id) + 1;
            _students.Add(student);
            return student;
        }

        public Student Delete(int id)
        {
            Student student = _students.FirstOrDefault(x => x.Id == id);
            if (student != null)
            {
                _students.Remove(student);
            }
            return student;
        }
    }
}
