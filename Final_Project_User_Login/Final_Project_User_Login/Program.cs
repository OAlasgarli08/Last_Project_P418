using Final_Project_User_Login.Controllers;
using Service.Enums;
using Service.Helpers.Exceptions;
using System.Buffers;

StudentController studentController = new StudentController();


static void Menus() 
{
    StudentController studentController = new StudentController();
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
                    Console.WriteLine("group create");
                    break;
                case (int)OperationTypes.GroupDelete:
                    Console.WriteLine("del");
                    break;
                case (int)OperationTypes.GroupEdit:
                    Console.WriteLine("edit");
                    break;
                case (int)OperationTypes.GroupGetById:
                    Console.WriteLine("getbyid");
                    break;
                case (int)OperationTypes.GroupGetAll:
                    Console.WriteLine("getall");
                    break;
                case (int)OperationTypes.GroupSearch:
                    Console.WriteLine("search");
                    break;
                case (int)OperationTypes.GroupSorting:
                    Console.WriteLine("sorting");
                    break;
                case (int)OperationTypes.StudentCreate:
                    studentController.Create();
                    break;
                case (int)OperationTypes.StudentDelete:
                    studentController.Delete();
                    break;
                case (int)OperationTypes.StudentEdit:
                    Console.WriteLine("edit");
                    break;
                case (int)OperationTypes.StudentGetById:
                    Console.WriteLine("getbyid");
                    break;
                case (int)OperationTypes.StudentGetAll:
                    studentController.GetAll();
                    break;
                case (int)OperationTypes.StudentFilter:
                    Console.WriteLine("filter");
                    break;
                case (int)OperationTypes.StudentSearch:
                    Console.WriteLine("search");
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

Menus();