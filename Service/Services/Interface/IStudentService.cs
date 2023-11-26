using Domain.Models;



namespace Service.Services.Interface
{
    public interface IStudentService
    {
        public void Create(Student student);
        public void Delete(Student student);
        Student GetById(int id);
        List<Student> GetAll();

        List<Student> SearchByFullName(string fullName);

        List<Student> SortingByAge(string text);

        public void Edit(int id, Student student);

        bool UniqueName(string fullname);

    }
}
