using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interface;


namespace Repository.Repositories
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {

        public List<Student> GetStudentsByAge(string text)
        {
            if (text == "desc")
            {
                return AppDbContext<Student>.datas.OrderByDescending(x => x.Age).ToList();
            }
            else if (text == "asc")
            {
                return AppDbContext<Student>.datas.OrderBy(x => x.Age).ToList();
            }
            return null;

        }

        public List<Student> SearchByFullName(string fullname)
        {
            return AppDbContext<Student>.datas.Where(x => x.Fullname.ToLower().Contains(fullname)).ToList();
        }

        public void Edit(int id, Student student)
        {
            Student ExistStudent = AppDbContext<Student>.datas.FirstOrDefault(x => x.Id == id);

            if (!string.IsNullOrWhiteSpace(student.Fullname))
            {

                ExistStudent.Fullname = student.Fullname;

            }


        }
    }
}
