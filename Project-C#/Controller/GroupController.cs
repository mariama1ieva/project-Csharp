using Service.Extensions;
using Service.Helpers.Constant;
using Service.Services;
using Service.Services.Interface;

namespace Project_C_.Controller
{
    public class GroupController
    {
        private readonly IGroupService _groupService;

        public GroupController()
        {
            _groupService = new GroupService();
        }

        public void Create()
        {
            ConsoleColor.Blue.WriteConsole("Add group name:");
        Name: string name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Name;
            }

            ConsoleColor.Blue.WriteConsole("Add group capacity:");
        Capacity: string capacitystr = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                ConsoleColor.Red.WriteConsole(Messages.RequiredField);
                goto Capacity;
            }

            int capacity;

            bool isCorrectCapacity = int.TryParse(capacitystr, out capacity);
            if (isCorrectCapacity)
            {
                _groupService.Create(new Group { Name = name, Capacity = capacity });
                ConsoleColor.Green.WriteConsole("Create process successful");

            }
            else if (!_groupService.UniqueName(name))
            {
                ConsoleColor.Green.WriteConsole("Create process successful");
            }

            else
            {
                ConsoleColor.DarkRed.WriteConsole("There is group with same name,please input again:");
                goto Name;
            }

            Group group = new()
            {
                Name = name,
                Capacity = capacity,
            };

            _groupService.Create(group);

        }

        public void Delete()
        {
            ConsoleColor.Blue.WriteConsole("Please input group name which you want to delete:");
        GroupName: string groupname = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(groupname))
            {
                Group name = _groupService.GetGroupByName(groupname);

                if (name != null)
                {
                    _groupService.Delete(name);
                    ConsoleColor.Green.WriteConsole("Group was deleted!");
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("There is no same group with the name. Please enter again group name:");
                    goto GroupName;
                }
            }
            else
            {
                ConsoleColor.Blue.WriteConsole("Can  not be empty:");
                goto GroupName;
            }
        }


        public void GetById()
        {
            ConsoleColor.Blue.WriteConsole("Please add id of group :");
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
                Group group = _groupService.GetById(Id);
                foreach (var item in _groupService.GetAll())
                {
                    ConsoleColor.Green.WriteConsole($"{item.Name}-{item.Capacity}");
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
            ConsoleColor.Blue.WriteConsole("For getting all groups,choose:1");
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
                    _groupService.GetAll();
                    foreach (var item in _groupService.GetAll())
                    {
                        ConsoleColor.Green.WriteConsole($"{item.Name}-{item.Capacity}");
                    }
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Wrong choosing,please try again:");
                    goto Text;
                }
            }
        }



    }

}

