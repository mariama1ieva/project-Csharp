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
            _studentRepository=new StudentRepository();
        }
        void IStudentService.Create(Student student)
        {
            _studentRepository.Create(student);
        }

        void IStudentService.Delete(Student student)
        {
            _studentRepository.Delete(student);
        }

        void IStudentService.Edit(Student student)
        {
            _studentRepository.Edit(student);
        }

        List<Student> IStudentService.GetAll()
        {
            return _studentRepository.GetAll();
        }

        Student IStudentService.GetById(int id)
        {
           return _studentRepository.GetById(id);
        }

       List <Student> IStudentService.SearchByFullName(string fullName)
        {
            return _studentRepository.SearchByFullName(fullName);
        }

        List<Student> IStudentService.SortingByAge(int age)
        {
           return _studentRepository.GetStudentsByAge(age);
        }
    }
}
