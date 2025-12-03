using System;
using oop_nachalo;

internal class Program
{
    static void Main(string[] args)
    {
        number_1();
        number_2();
        number_3();
     




        Console.ReadKey();
    }

    static Item CreatItem()
    {
        Console.WriteLine("Введите название предмета");
        string name = Console.ReadLine();
        Console.WriteLine("Задайте цену");
        int.TryParse(Console.ReadLine(), out int price);
        Console.WriteLine("Задайте вес");
        float.TryParse(Console.ReadLine(), out float weight);
        Item newitem = new Item(name, price, weight);
        return newitem;
    }

    static void number_1()
    {
        Item item1 = (CreatItem());
        Item item2 = (CreatItem());
        Item[] items = new Item[2];
        items[0] = item1;
        items[1] = item2;
        items[0].DisplayInfo();
        items[1].DisplayInfo();
    }

    static void number_2()
    {
        Item[] items = new Item[5];
        PlayerInventory inventory = new PlayerInventory(50f, items);
        Item item1 = CreatItem();
        inventory.AddItem(item1);

        Item item2 = CreatItem();
        inventory.AddItem(item2);

        Item item3 = CreatItem();
        inventory.AddItem(item3);

        Item item4 = CreatItem();
        inventory.AddItem(item4);

        Item item5 = CreatItem();
        inventory.AddItem(item5);

        Item item6 = CreatItem();
        inventory.AddItem(item6);

        inventory.GetTotalWeight();
    }

    static void number_3()
    {
        Console.WriteLine("Введите имя персонажа");
        Item[] items = new Item[5];
        PlayerInventory inventory = new PlayerInventory(50f, items);
        string Name = Console.ReadLine();
        Player player = new Player(Name, inventory);
        Item item11 = CreatItem();
        player.PickUpItem(item11);
        Item item22 = CreatItem();
        player.PickUpItem(item22);
        Console.WriteLine($"Игрок: {Name}");
        player.ShowInventory();
        player.Inventory.GetTotalWeight();
        player.GetInventoryValue();

    }



}
