using Domain.Models;
using Repository.Data;
using Repository.Repositories.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {
        bool IUserRepository.Login(string email, string password)
        {
            throw new NotImplementedException();
        }

        bool IUserRepository.Register(string name, string surname, string password, string email, int age, string confirmpassword)
        {
            throw new NotImplementedException();
        }
    }
}
