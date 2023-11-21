using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IUserRepository:IBaseRepository<User>
    {
        public bool Register(string name,string surname,string password,string email,int age,string confirmpassword);
        public bool Login(string email, string password);


    }
}
