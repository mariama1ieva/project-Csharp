using Service.Extensions;
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

            ConsoleColor.Blue.WriteConsole("Add group capacity:");
        Capacity: string capacitystr = Console.ReadLine();

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
    }
}
