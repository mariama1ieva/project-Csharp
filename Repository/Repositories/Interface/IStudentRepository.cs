using Domain.Models;


namespace Repository.Repositories.Interface
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        public List<Student> GetStudentsByAge(int age);
        List<Student> SearchByFullName(string fullname);
    }
}
