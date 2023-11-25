using Service.Enums;
using System.Buffers;

while (true) 
{
    GetMenu();

    Operation:  string operationStr = Console.ReadLine();
    int operation;
    bool isCorrectOperation = int.TryParse(operationStr, out operation);

    if (isCorrectOperation)
    {
        switch (operation) 
        {
            case (int)OperationTypes.GroupCreate:
                Console.WriteLine("Create group");
                break;
            case (int)OperationTypes.GroupDelete:
                Console.WriteLine("del");
                break;
            case (int)


        }          
    }
    else
    {
        Console.WriteLine("Operation format is incorrect, try again! : ");
        goto Operation;
    }

}    

static void GetMenu()
{
    Console.WriteLine("Welcome to our application");
    Console.WriteLine("Please select one option: Group operations: 1-Create, 2-Delete, 3-Edit, 4-GetById, 5-GetAll, 6-Search, 7-Sorting | Student operations : 8-Create, 9-Delete, 10- Edit, 11-GetById, 12-GetAll, 13 - Filter, 14 - Search");



}