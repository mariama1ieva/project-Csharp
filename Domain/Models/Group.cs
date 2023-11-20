using Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class Group:BaseEntity
    {
        public int Capacity { get; set; }
        public string Name { get; set; }
    }
}
