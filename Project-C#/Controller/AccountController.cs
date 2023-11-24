using Domain.Models;
using Service.Extensions;
using Service.Helpers.Constant;
using Service.Helpers.Exceptions;
using Service.Services;
using Service.Services.Interface;


namespace Project_C_.Controller
{
    public class AccountController
    {
        private readonly IAccountService _accountService;
        public AccountController()
        {
            _accountService = new AccountService();
        }

        public void Register()
        {
            ConsoleColor.Blue.WriteConsole("Add name:");
        Name: string name = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(name))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Name;
            }

            ConsoleColor.Blue.WriteConsole("Add surname:");
        Surname: string surname = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(surname))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Surname;
            }

            ConsoleColor.Blue.WriteConsole("Add Age:");
        Age: string age = Console.ReadLine();

            int ageStr;

            bool isCorrect = int.TryParse(age, out ageStr);
            if (!isCorrect)
            {
                ConsoleColor.Red.WriteConsole("Format is wrong,please try again:");
                goto Age;
            }

            if (string.IsNullOrWhiteSpace(age))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Age;
            }

            ConsoleColor.Blue.WriteConsole("Add email:");
        Email: string email = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(email))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Email;
            }
            else if (!email.Contains("@"))
            {
                ConsoleColor.Red.WriteConsole("invalid email,please add again:");
                goto Email;
            }

            ConsoleColor.Blue.WriteConsole("Add password:");
        Password: string password = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(password))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Password;
            }

            ConsoleColor.Blue.WriteConsole("Add confirmpassword:");
        Confirmpassword: string confirmpassword = Console.ReadLine();

            try
            {
                if (confirmpassword == password)
                {
                    ConsoleColor.Green.WriteConsole("Register is success");
                }
                else
                {
                    throw new FailedException();

                }
            }
            catch (Exception ex)
            {

                ConsoleColor.Red.WriteConsole(ex.Message);
                goto Confirmpassword;
            }

            if (string.IsNullOrWhiteSpace(confirmpassword))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Confirmpassword;
            }

            User user = new User()
            {
                Age = ageStr,
                Name = name,
                Email = email,
                Password = password,

            };
            _accountService.Register(user);
        }
        public void Login()
        {
            ConsoleColor.Blue.WriteConsole("Add email:");

        Email: string inputEmail = Console.ReadLine();

            if (string.IsNullOrEmpty(inputEmail))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Email;
            }
            else if (!inputEmail.Contains("@"))
            {
                ConsoleColor.Red.WriteConsole("invalid email,please add again:");
                goto Email;
            }

            ConsoleColor.Blue.WriteConsole("Add password:");

        PasswordInput: string inputPassword = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(inputPassword))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto PasswordInput;
            }

            var loginResult = _accountService.Login(inputEmail, inputPassword);

            if (loginResult)
            {
                ConsoleColor.Green.WriteConsole("Login successful");
                //return true;
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Invalid email or password. Please try again.");
                //return false;
            }
        }
    }
}
