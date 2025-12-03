using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        string str = Console.ReadLine();
        int i;
        i = int.Parse(str);
        Console.WriteLine(i + 100);

    }
}

