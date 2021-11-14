using System.Collections.Generic;

namespace StudentManagement.Models
{
    public class SQLStudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;
        public SQLStudentRepository(AppDbContext context)
        {
            this._context = context;
        }
        public Student Create(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        public Student Delete(int id)
        {
            Student student = _context.Students.Find(id);
            if (student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
            }
            return student;

        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students;
        }

        public Student GetById(int id)
        {
            return _context.Students.Find(id);
        }

        public Student Update(Student updatestudent)
        {
            var student = _context.Students.Attach(updatestudent);
            student.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return updatestudent;
        }
    }
}
