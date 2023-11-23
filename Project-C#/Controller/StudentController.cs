using Service.Services;
using Service.Services.Interface;


namespace Project_C_.Controller
{
    public class StudentController
    {
        private readonly IStudentService _studentService;
        public StudentController()
        {
            _studentService= new StudentService();
        }

        
    }
}
