using Domain.Models;



namespace Service.Services.Interface
{
    public interface IStudentService
    {
        public void Create(Student student);
        public void Edit(Student student);
        public void Delete(Student student);
        Student GetById(int id);
        List<Student> GetAll();

        List<Student> SearchByFullName(string fullName);

        List<Student> SortingByAge(int age);
    }
}
