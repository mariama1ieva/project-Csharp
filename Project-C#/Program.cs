using Project_C_.Controller;
using Service.Enum;
using Service.Extensions;

AccountController accountController = new AccountController();
GroupController groupController = new GroupController();
StudentController studentController = new StudentController();





while (true)
{
    GetMenues();

Operations: string operation = Console.ReadLine();

    if (operation == "1")
    {
        accountController.Register();
        goto Operations;

    }
    else if (operation == "2")
    {
        accountController.Login();

    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation is wrong,please try again:");
        goto Operations;
    }





Case: GetMainMenu();

Op: string opstr = Console.ReadLine();
    int op;
    bool isCorrectOp = int.TryParse(opstr, out op);

    if (isCorrectOp)
    {
        switch (op)
        {
            case (int)GroupOperationtypes.GroupCreate:
                groupController.Create();
                goto Case;
            case (int)GroupOperationtypes.GroupGetAll:
                groupController.GetAll();
                goto Case;
            case (int)GroupOperationtypes.GroupDelete:
                groupController.Delete();
                goto Case;
            case (int)GroupOperationtypes.GroupGetById:
                groupController.GetById();
                goto Case;
            case (int)GroupOperationtypes.GroupSearch:
                groupController.Search();
                goto Case;
            case (int)GroupOperationtypes.GroupSort:
                groupController.Sort();
                goto Case;
            case (int)GroupOperationtypes.GroupEdit:
                groupController.Edit();
                goto Case;
            case (int)StudentOperationTypes.StudentCreate:
                studentController.Create();
                goto Case;
            case (int)StudentOperationTypes.StudentGetAll:
                studentController.GetAll();
                goto Case;
            case (int)StudentOperationTypes.StudentDelete:
                studentController.Delete();
                goto Case;
            case (int)StudentOperationTypes.StudentGetById:
                studentController.GetById();
                goto Case;
            case (int)StudentOperationTypes.StudentSearch:
                studentController.Search();
                goto Case;
            case (int)StudentOperationTypes.StudentSort:
                studentController.Sort();
                goto Case;
            case (int)StudentOperationTypes.StudentEdit:
                studentController.Edit();
                goto Case;

            default:
                ConsoleColor.Red.WriteConsole("Operation is wrong,please try again:");
                goto Op;
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation format is wrong,please try again:");
        goto Op;
    }
}
static void GetMenues()
{
    Console.WriteLine("Account operations:1 - Register ;  2 - Login");
}

static void GetMainMenu()
{

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("       Welcome our aplication");
    Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~");
    Console.WriteLine("       Please select one operation:     ");
    Console.ResetColor();
    ConsoleColor.Blue.WriteConsole("Group Operation: (3)-Create; (4)-GetAll; (5)-Edit; (6)-Delete; (7)-GetById; (8)-Search ; (9)-Sort     Student Operation: (10)-Create ; (11)-GetAll; (12)-Edit; (13)-Delete; (14)-GetById; (15)-Search; (16)-Sort");
}


