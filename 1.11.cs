using System;
    internal class Program
    {
        static void Main(string[] args)
        {
        int a1;
        int a2;
        Console.WriteLine("Hello, world!");
        Console.WriteLine("Введите два любых числа");
        a1 = int.Parse(Console.ReadLine());
        a2 = int.Parse(Console.ReadLine());
        Console.WriteLine($"{a1 + a2},{a1 - a2},{a1*a2}");
        if (a2!= 0)
        {
            Console.WriteLine(a1 / a2);
        }
        }
    }

