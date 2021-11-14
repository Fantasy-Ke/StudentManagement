using System.Collections.Generic;

namespace StudentManagement.Models
{
    public interface IStudentRepository
    {
        
        /// <summary>
        /// 通过id查询
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Student GetById(int id);
        /// <summary>
        /// 查询全部
        /// </summary>
        /// <returns></returns>
        IEnumerable<Student> GetAllStudents();
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        Student Update(Student student);
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>
        Student Delete(int id);
        /// <summary>
        /// 添加
        /// </summary>
        /// <param name="student"></param>
        /// <returns></returns>

        Student Create(Student student);

        
    }
}
