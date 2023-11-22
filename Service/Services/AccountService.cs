using Domain.Models;
using Repository.Data;
using Repository.Repositories;
using Repository.Repositories.Interface;
using Service.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Service.Services
{
    public class AccountService : IAccountService
    {
        private readonly IAccountRepository _accountRepository;
        public AccountService()
        {
            _accountRepository= new AccountRepository();
        }
        public bool Login(string email, string password)
        {
           return _accountRepository.Login(email, password);
        }

        public void Register(User user)
        {
          
            _accountRepository.Register(user);
          
        }

       
    }
}
