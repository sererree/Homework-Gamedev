using System;
internal class Program
{
    static void Main(string[] args)
    {
        int v;
        Console.WriteLine("Введите возраст");
        v = int.Parse(Console.ReadLine());
        if (v < 12)
        {
            Console.WriteLine("ребенок");
        }
        if (v >= 18)
        {
            Console.WriteLine("взрослый");
        }
        else
        {
            Console.WriteLine("подросток");
        }
        Console.ReadKey();
    }
}
