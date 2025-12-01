using System;
internal class Program
{
    static void Main(string[] args)
    {
        int a;
        Console.WriteLine("введите число");
        a = int.Parse(Console.ReadLine());
        if (a%3==0)
        {
            if (a%5==0)
            {
                Console.WriteLine("делится");
            }
            else
            {
                Console.WriteLine("не делится");
            }
        }

    }
}

