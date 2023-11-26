using Final_Project_User_Login.Controllers;
using Service.Enums;
using System.Buffers;



static void Menus() 
{
    StudentController studentController = new StudentController();
    GroupController groupController = new GroupController();
    while (true)
    {
        GetMenu();

    Operation: string operationStr = Console.ReadLine();
        int operation;
        bool isCorrectOperation = int.TryParse(operationStr, out operation);

        if (isCorrectOperation)
        {
            switch (operation)
            {
                case (int)OperationTypes.GroupCreate:
                    groupController.GroupCreate();
                    break;
                case (int)OperationTypes.GroupDelete:
                    groupController.GroupDelete();
                    break;
                case (int)OperationTypes.GroupEdit:
                    groupController.GroupEdit();
                    break;
                case (int)OperationTypes.GroupGetById:
                    groupController.GroupGetById();
                    break;
                case (int)OperationTypes.GroupGetAll:
                    groupController.GroupGetAll();
                    break;
                case (int)OperationTypes.GroupSearch:
                    groupController.GroupSearch();
                    break;
                case (int)OperationTypes.GroupSorting:
                    groupController.GroupSort();   
                    break;
                case (int)OperationTypes.StudentCreate:
                    studentController.StudentCreate();
                    break;
                case (int)OperationTypes.StudentDelete:
                    studentController.StudentDelete();
                    break;
                case (int)OperationTypes.StudentEdit:
                    studentController.StudentEdit();
                    break;
                case (int)OperationTypes.StudentGetById:
                    studentController.StudentGetById();
                    break;
                case (int)OperationTypes.StudentGetAll:
                    studentController.StudentGetAll();
                    break;
                case (int)OperationTypes.StudentFilter:
                    studentController.StudentSort();
                    break;
                case (int)OperationTypes.StudentSearch:
                    studentController.StudentSearch();
                    break;
                default:
                    Console.WriteLine("Operation not found");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Operation format is incorrect, try again! : ");
            goto Operation;
        }
    }
}    

static void GetMenu()
{
    Console.WriteLine("Welcome to our application");
    Console.WriteLine("Please select one option: Group operations: 1-Create, 2-Delete, 3-Edit, 4-GetById, 5-GetAll, 6-Search, 7-Sorting | Student operations : 8-Create, 9-Delete, 10- Edit, 11-GetById, 12-GetAll, 13 - Filter, 14 - Search");
}

static void GetMenu2()
{
    Console.WriteLine("Choice from Login and Register");
    Console.WriteLine("Please select one option: Login = 1 ; Register = 2");
}




static void SignUp()
{
    UserController userController = new UserController();

    Console.WriteLine("Welcome!");

    userController.SignUp();
}

static void Login()
{
    UserController userController = new UserController();
    Console.WriteLine("Please Log in");


    userController.Login();

    
}

SignUp();

GetMenu2();
Operation2: string operationStr = Console.ReadLine();
int operation;
bool isCorrectOperation = int.TryParse(operationStr, out operation);
if (isCorrectOperation)
{

    switch (operation)
    {
        case (int)OperationTypes2.Login:
            Login();
            Menus();
            break;
        case (int)OperationTypes2.Register:
            SignUp();
            break;

        default:
            Console.WriteLine("This choice doesn't exist");
            break;

    }
}
else
{
    Console.WriteLine("Operation format is incorrect, try again! : ");
    goto Operation2;
}

Menus();

