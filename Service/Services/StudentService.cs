using Domain.Models;
using Repository.Repositories;
using Repository.Repositories.Interface;
using Service.Services.Interface;


namespace Service.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService()
        {
            _studentRepository = new StudentRepository();
        }

        public void Edit(int id, Student student)
        {
            _studentRepository.Edit(id, student);
        }

        public List<Student> SortingByAge(string text)
        {
            return _studentRepository.GetStudentsByAge(text);
        }

        void IStudentService.Create(Student student)
        {
            _studentRepository.Create(student);
        }

        void IStudentService.Delete(Student student)
        {
            _studentRepository.Delete(student);
        }

        List<Student> IStudentService.GetAll()
        {
            return _studentRepository.GetAll();
        }

        Student IStudentService.GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        List<Student> IStudentService.SearchByFullName(string fullName)
        {
            return _studentRepository.SearchByFullName(fullName);
        }



    }
}
