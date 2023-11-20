using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Student:BaseEntity
    {
        public string Fullname { get; set; }
        public string Adress { get; set; }
        public int Age { get; set; }
        public int Phone { get; set; }
    }
}
