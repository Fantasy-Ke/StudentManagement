namespace StudentManagement.Models
{
    public interface IStudentRepository
    {
        Student GetById(int id);
        
        void Save(Student student);
    }
}
