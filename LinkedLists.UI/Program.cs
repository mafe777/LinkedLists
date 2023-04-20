
using LinkedLists.Logic;
using System.ComponentModel.Design;

Console.WriteLine("*----- Linked Lists -----*");
Console.WriteLine(" ");
var singlelist = new SingleList<string>();
FillList();

void FillList()
{
    singlelist.Add("a");
    singlelist.Add("b");
    singlelist.Add("c");
    singlelist.Add("d");
    singlelist.Add("e");
    singlelist.Add("f");
}

int option; 
do
{
    option = Menu();
    switch (option)
    {
        case 1: AddItem(); break;
        case 2: ShowList(); break;
        case 3: RemoveItem(); break;
       // case 4: 
    
        default:break;
    }
} while (option !=0);

void RemoveItem()
{
    Console.WriteLine("Enter The Item You Want To Remove");
    var item = Console.ReadLine();
    var result = singlelist.Remove(item!);
    if (result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Item Removed Succesfully");
        Console.ForegroundColor = ConsoleColor.White;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Item Not Founded In The List");
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}

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
    Console.WriteLine("3. Remove Item");
    Console.WriteLine("0. Exit");
    Console.Write("choose the option:  ");
    var option = Console.ReadLine();
    return Convert.ToInt32(option);
}