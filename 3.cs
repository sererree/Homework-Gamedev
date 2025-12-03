using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("ведите число");
        string s = Console.ReadLine();
        if (int.TryParse(s, out int number))
        {
            Console.WriteLine(number * number);
        }
        else
        {
            Console.WriteLine("ошибка ввода");
        }
        Console.ReadKey();

    }
}


