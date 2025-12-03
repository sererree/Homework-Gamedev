using System;
using magic;

internal class Program
{
    static void Main(string[] args)
    {
        
        Mage mage = new Mage("Лабубу", 15, 15);
        Goblin goblin = new Goblin("Матан", 20, 20);

      
        Battle battle = new Battle(mage, goblin);
        battle.StartBattle();

        Console.ReadKey();
    }
}
