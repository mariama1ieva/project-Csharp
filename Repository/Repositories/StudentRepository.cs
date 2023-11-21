using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {
        public string SearchByFullName(string fullname)
        {
            return AppDbContext<Student>.datas.Where(x => x.Fullname==fullname).ToString();
        }

        public List<Student> GetStudentsByAge(int age)
        {
             return AppDbContext<Student>.datas.OrderByDescending(x => x.Age).ToList();
        }
    }
}
