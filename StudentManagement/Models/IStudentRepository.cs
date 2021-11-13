using System.Collections.Generic;

namespace StudentManagement.Models
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        
        void Save(Student student);

        IEnumerable<Student> GetAllStudents();
    }
}
