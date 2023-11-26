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
            if (_groupService.UniqueName(name))
            {
                ConsoleColor.Red.WriteConsole("Please input different name:");
                goto Name;
            }

            ConsoleColor.Blue.WriteConsole("Add group capacity:");
        Capacity: string capacity = Console.ReadLine();
            int capacityStr = 0;


            if (!string.IsNullOrEmpty(capacity))
            {

                bool isCorrectCapacity = int.TryParse(capacity, out capacityStr);
                if (!isCorrectCapacity)
                {
                    ConsoleColor.Red.WriteConsole("Format is wrong,try again:");
                    goto Capacity;
                }

            }

            Group group = new()
            {
                Name = name,
                Capacity = capacityStr,
            };

            _groupService.Create(group);
            ConsoleColor.Green.WriteConsole("Create process successful");

        }

        public void Delete()
        {
            ConsoleColor.Blue.WriteConsole("Please input group id which you want to delete:");
        Id: string idStr = Console.ReadLine();


            int id;

            bool isCorrectId = int.TryParse(idStr, out id);
            if (isCorrectId)
            {

                if (!string.IsNullOrWhiteSpace(idStr))
                {
                    Group group = _groupService.GetById(id);

                    if (group != null)
                    {
                        _groupService.Delete(group);
                        ConsoleColor.Green.WriteConsole("Group was deleted!");
                    }
                    else
                    {
                        ConsoleColor.Blue.WriteConsole("Can  not be empty:");
                        goto Id;
                    }
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("There is no same group with the id. Please enter again group id:");
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

                if (group != null)
                {
                    foreach (var item in _groupService.GetAll())
                    {
                        ConsoleColor.Green.WriteConsole($"{item.Name}-{item.Capacity}");
                    }

                }
                else
                {
                    ConsoleColor.Red.WriteConsole("Please try again:");
                    goto Id;
                }
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

        public void Search()
        {
            ConsoleColor.Blue.WriteConsole("Please enter group name which you want to search:");
        GroupName: string name = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(name))
            {
                List<Group> groups = _groupService.GetGroupByName(name);

                if (groups != null)
                {
                    foreach (var item in groups)
                    {
                        ConsoleColor.Green.WriteConsole($"{item.Name}-{item.Capacity}");
                    }
                }
                else
                {
                    ConsoleColor.Red.WriteConsole("there is not group as this name,please try again:");
                    goto GroupName;
                }
            }
            else
            {
                ConsoleColor.Red.WriteConsole("Can  not be empty:");
                goto GroupName;
            }
        }

        public void Sort()
        {
            ConsoleColor.Blue.WriteConsole("Please,add sort text");
            string text = Console.ReadLine();
            List<Group> groups = _groupService.SortingByCapacity(text);

            foreach (var item in groups)
            {
                ConsoleColor.Green.WriteConsole($"{item.Name} - {item.Capacity}");
            }

        }

        public void Edit()
        {
            ConsoleColor.Blue.WriteConsole("Please add Id for editing:");
        Id: string IdStr = Console.ReadLine();

            int id;
            bool isCorrectId = int.TryParse(IdStr, out id);

            if (isCorrectId)
            {
                var group = _groupService.GetById(id);

            Edit: ConsoleColor.Magenta.WriteConsole("Please,add Name");
                string name = Console.ReadLine();


                ConsoleColor.Magenta.WriteConsole("Please,add Capacity");
            Capacity: string CapacityStr = Console.ReadLine();
                int capacity;
                bool isCorrectCapacity = int.TryParse(CapacityStr, out capacity);

                if (isCorrectCapacity)
                {
                    _groupService.Edit(id, new Group { Name = name, Capacity = capacity });

                    ConsoleColor.Green.WriteConsole("Group edit is succes");
                }
                else
                {

                    ConsoleColor.Red.WriteConsole("Format is wrong,please try again:");
                    goto Edit;
                }

            }
            else
            {
                ConsoleColor.Red.WriteConsole("Format is wrong,please try again:");
            }
        }



    }
}

