using Domain.Models;


namespace Repository.Repositories.Interface
{
    public interface IStudentRepository : IBaseRepository<Student>
    {
        public string SearchByFullName(string fullname);

        public List<Student> GetStudentsByAge(int age);
    }
}
