using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Data
{
    public static class AppDbContext<T>
    {
        public static List<T> datas;

        static AppDbContext()
        {
            datas = new List<T>();
        }


        public static List<Group> Groups()
        {
            return new List<Group>();
            {
                new Group() { Id = 1, Name = "P418", Capacity = 20 };
                new Group() { Id = 2, Name = "M321", Capacity = 10 };
                new Group() { Id = 3, Name = "C543", Capacity = 25 };
            }
        }

        public static List<User> Users()
        {
            return new List<User>();
            {
                new User() { Id = 11, Name = "Meryem", Age = 23, Email = "meryem@gmail.com", Surname = "Aliyeva", Password = "123" };
                new User() { Id = 12, Name = "Ali", Age = 18, Email = "ali@gmail.com", Surname = "Mammedov", Password = "456" };
                new User() { Id = 13, Name = "Nigar", Age = 31, Email = "nigar@gmail.com", Surname = "Qasimova", Password = "789" };

            }
        }

    }
}
