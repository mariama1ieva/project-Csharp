﻿using Domain.Common;
using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Repositories.Interface
{
    public interface IAccountRepository:IBaseRepository<User> 
    {
        public void Register(User user);
        public bool Login(string email,string password);
    }
}
