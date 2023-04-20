
using LinkedLists.Logic;
using System.ComponentModel.Design;

Console.WriteLine("*-----Linked Lists-----*");
var singlelist = new SingleList<string>();


int option; 
do
{
    option = Menu();
    switch (option)
    {
        case 1: AddItem(); break;
        case 2: ShowList(); break;
        default:break;
    }
} while (option !=0);

void ShowList()
{
    if (singlelist.IsEmpty) 
    {
        Console.WriteLine("The List Is Empty");
        return;
    }
    Console.WriteLine("The List Elements Are: ");
    Console.WriteLine(singlelist);

}

void AddItem()
{
    Console.WriteLine("Enter The Item");
    var item = Console.ReadLine();
    singlelist.Add(item!);
}


int Menu()
{
    Console.WriteLine("1. Add Item");
    Console.WriteLine("2. Show List");
    Console.WriteLine("0. Exit");
    Console.Write("choose the option...");
    var option = Console.ReadLine();
    return Convert.ToInt32(option);
}