using Project_C_.Controller;

AccountController accountController = new AccountController();
GroupController groupController = new GroupController();
groupController.Create();
//groupController.Delete();
//groupController.GetById();
groupController.GetAll();

//while (true)
//{
//    GetMenues();

//    Operation: string operationStr=Console.ReadLine();
//    int operation;
//    bool isCorrectoperation=int.TryParse(operationStr, out operation);

//    if(isCorrectoperation )
//    {
//        switch (operation)
//        {
//            case (int)AccountOperationTypes.AccountRegister:
//                accountController.Register();
//                break;
//            case (int)AccountOperationTypes.AccountLogin:
//                accountController.Login();
//                break;

//            default:ConsoleColor.Red.WriteConsole("Operation is wrong,Please try again:");
//                goto Operation;

//        }
//    }
//    else
//    {
//        ConsoleColor.Red.WriteConsole("Operation format is wrong,please try again:");
//        goto Operation;
//    }
//}

//static void GetMenues()
//{
//    Console.WriteLine("Account operations:1 - Register ;  2 - Login");
//}

