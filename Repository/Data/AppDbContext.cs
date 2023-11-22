﻿using Domain.Models;
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
      
    }
}
