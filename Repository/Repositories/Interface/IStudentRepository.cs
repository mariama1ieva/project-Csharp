using Domain.Models;


namespace Repository.Repositories.Interface
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        public List<Student> GetStudentsByAge(string text);
        List<Student> SearchByFullName(string fullname);
        void Edit(int id, Student student);


    }
}
