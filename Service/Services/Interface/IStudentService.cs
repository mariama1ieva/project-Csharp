using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;



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
