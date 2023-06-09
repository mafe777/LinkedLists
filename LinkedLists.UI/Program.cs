﻿
using LinkedLists.Logic;
using System.ComponentModel.Design;

Console.WriteLine("*----- Double Lists -----*");
var fruits = new DoubleList <Fruit>();
fruits.Add(new Fruit { Name = "MANGO", Price = 4500 });
fruits.Add(new Fruit { Name = "KIWI", Price = 6000 });
fruits.Add(new Fruit { Name = "AGUACATE", Price = 5000 });
fruits.Add(new Fruit { Name = "FRESA", Price = 3800 });

Console.WriteLine("*----- List In Order -----*");
Console.WriteLine(fruits);
Console.WriteLine("*----- List In Inverted Order -----*");
Console.WriteLine(fruits.ToInvertedList());

Console.WriteLine("*----- List Converted To Array -----*");

var fruitsArray = fruits.ToArray();
foreach (var fruit in fruitsArray.OrderBy(fruit => fruit.Price))
{
    Console.WriteLine(fruit);
}

/*
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
        case 4: InserItem(); break;
    
        default:break;
    }
} while (option !=0);

void InserItem()
{
    Console.WriteLine(" ");
    Console.WriteLine("*Enter The Current Item");
    var current = Console.ReadLine();
    Console.WriteLine("*Enter The New Item");
    var item = Console.ReadLine();
    var result = singlelist.Insert(current!,item!);
    if (result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" ");
        Console.WriteLine("*Item Inserted Succesfully");
        Console.ForegroundColor = ConsoleColor.White;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" ");
        Console.WriteLine("*Item Not Founded In The List");
        Console.ForegroundColor = ConsoleColor.White;
    }

}

void RemoveItem()
{
    Console.WriteLine(" ");
    Console.WriteLine("*Enter The Item You Want To Remove");
    var item = Console.ReadLine();
    var result = singlelist.Remove(item!);
    if (result)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(" ");
        Console.WriteLine("*Item Removed Succesfully");
        Console.ForegroundColor = ConsoleColor.White;

    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" ");
        Console.WriteLine("*Item Not Founded In The List");
        Console.ForegroundColor = ConsoleColor.White;
    }
    
}

void ShowList()
{
    if (singlelist.IsEmpty) 
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(" ");
        Console.WriteLine("*The List Is Empty, Please Fill It");
        Console.ForegroundColor = ConsoleColor.White;
        return;
    }
    Console.WriteLine(" ");
    Console.WriteLine("*The List Elements Are: ");
    Console.WriteLine(singlelist);

}

void AddItem()
{
    Console.WriteLine(" ");
    Console.WriteLine("*Enter The Item");
    var item = Console.ReadLine();
    singlelist.Add(item!);
}

int Menu()
{
    Console.WriteLine("    *-- MENU--*   ");
    Console.WriteLine("   1. Add Item");
    Console.WriteLine("   2. Show List");
    Console.WriteLine("   3. Remove Item");
    Console.WriteLine("   4. Insert Item");
    Console.WriteLine("   0. Exit");
    Console.Write(" *choose the option:  ");
    var option = Console.ReadLine();
    return Convert.ToInt32(option);
}
*/