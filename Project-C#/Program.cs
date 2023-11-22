using Project_C_.Controller;
using Service.Enum;
using Service.Helpers;

AccountController accountController = new AccountController();



while (true)
{
    GetMenues();
    
    Operation: string operationStr=Console.ReadLine();
    int operation;
    bool isCorrectoperation=int.TryParse(operationStr, out operation);

    if(isCorrectoperation )
    {
        switch (operation)
        {
            case (int)OperationTypes.AccountRegister:
                accountController.Register();
                break;
            case (int)OperationTypes.AccountLogin:
                accountController.Login();
                break;

            default:ConsoleColor.Red.WriteConsole("Operation is wrong,Please try again:");
                goto Operation;
              
        }
    }
    else
    {
        ConsoleColor.Red.WriteConsole("Operation format is wrong,please try again:");
        goto Operation;
    }
}

static void GetMenues()
{
    Console.WriteLine("Account operations:1 - Register ;  2 - Login");
}

