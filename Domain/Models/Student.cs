using Domain.Common;

namespace Domain.Models
{
    public class Student : BaseEntity
    {
        public string Fullname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }
        public string Phone { get; set; }
        public Group Group { get; set; }
    }
}
