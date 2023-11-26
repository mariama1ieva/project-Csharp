using Domain.Models;
using Service.Extensions;
using Service.Helpers.Constant;
using Service.Services;
using Service.Services.Interface;

namespace Project_C_.Controller
{
    public class StudentController
    {
        private readonly IStudentService _studentService;
        private readonly IGroupService _groupService;
        public StudentController()
        {
            _studentService = new StudentService();
            _groupService = new GroupService();
        }


        public void Create()
        {
            ConsoleColor.Blue.WriteConsole("Add GroupId:");
        Id: string IdStr = Console.ReadLine();

            int id;
            bool isCorrectId = int.TryParse(IdStr, out id);

            Group group = _groupService.GetById(id);


            if (string.IsNullOrEmpty(IdStr))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Id;
            }

            if (group.Id == id)
            {

                Create();
            }
            else
            {
                goto Id;
            }

            ConsoleColor.Blue.WriteConsole("Add student fullname:");
        FullName: string fullname = Console.ReadLine();

            if (string.IsNullOrEmpty(fullname))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto FullName;
            }

            ConsoleColor.Blue.WriteConsole("Add student address:");
        Address: string address = Console.ReadLine();

            if (string.IsNullOrEmpty(address))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Address;
            }

            ConsoleColor.Blue.WriteConsole("Add student phone:");
        Phone: string phone = Console.ReadLine();

            if (string.IsNullOrEmpty(phone))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Phone;
            }

            ConsoleColor.Blue.WriteConsole("Add student age:");
        Age: string age = Console.ReadLine();
            int ageStr = 0;


            if (!string.IsNullOrEmpty(age))
            {

                bool isCorrectAge = int.TryParse(age, out ageStr);
                if (!isCorrectAge)
                {
                    ConsoleColor.Red.WriteConsole("Format is wrong,try again:");
                    goto Age;
                }

            }

            Student student = new()
            {
                Fullname = fullname,
                Age = ageStr,
                Phone = phone,
                Address = address,
                Group = group
            };

            _studentService.Create(student);
            ConsoleColor.Green.WriteConsole("Create process successful");


        }

        public void Delete()
        {
            ConsoleColor.Blue.WriteConsole("Please input student id which you want to delete:");
        Id: string idStr = Console.ReadLine();


            int id;

            bool isCorrectId = int.TryParse(idStr, out id);
            if (isCorrectId)
            {

                if (!string.IsNullOrWhiteSpace(idStr))
                {
                    Student student = _studentService.GetById(id);

                    if (student != null)
                    {
                        _studentService.Delete(student);
                        ConsoleColor.Green.WriteConsole("Student was deleted!");
                    }
                    else
                    {
                        ConsoleColor.Blue.WriteConsole("Can  not be empty:");
                        goto Id;
                    }
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("There is no same student with the id. Please enter again group id:");
                    goto Id;
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Format is wrong,please try again:");
                goto Id;
            }
        }

        public void GetById()
        {
            ConsoleColor.Blue.WriteConsole("Please add id of student :");
        Id: string idStr = Console.ReadLine();

            if (string.IsNullOrEmpty(idStr))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Id;
            }
            int Id;
            bool isCorrect = int.TryParse(idStr, out Id);
            if (isCorrect)
            {
                Student student = _studentService.GetById(Id);

                if (student != null)
                {
                    foreach (var item in _studentService.GetAll())
                    {
                        ConsoleColor.Green.WriteConsole($"{item.Fullname}-{item.Address}-{item.Group}-{item.Age}");
                    }

                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please try again:");
                    goto Id;
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Format is wrong,please try again:");
                goto Id;
            }
        }

        public void GetAll()
        {
            ConsoleColor.Blue.WriteConsole("For getting all students,choose:1");
        Text: string text = Console.ReadLine();

            if (string.IsNullOrEmpty(text))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Text;
            }
            else
            {
                if (text == "1")
                {
                    _studentService.GetAll();
                    foreach (var item in _studentService.GetAll())
                    {
                        ConsoleColor.Green.WriteConsole($"{item.Fullname}-{item.Address} - {item.Group} - {item.Age} - {item.Address}");
                    }
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Wrong choosing,please try again:");
                    goto Text;
                }
            }
        }

        public void Search()
        {
            ConsoleColor.Blue.WriteConsole("Please enter student name which you want to search:");
        Fullname: string fullname = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(fullname))
            {
                List<Student> student = _studentService.SearchByFullName(fullname);

                if (student != null)
                {
                    foreach (var item in student)
                    {
                        ConsoleColor.Green.WriteConsole($"{item.Fullname}-{item.Age} - {item.Group} - {item.Address} - {item.Phone}");
                    }
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("there is not student as this name,please try again:");
                    goto Fullname;
                }
            }
            else
            {
                ConsoleColor.Blue.WriteConsole("Can  not be empty:");
                goto Fullname;
            }
        }








    }
}
