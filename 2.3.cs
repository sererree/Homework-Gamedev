using System;
internal class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("введите число");
        n = int.Parse(Console.ReadLine());
        int i;
        for (i=1; i<=10; i++)
        {
            Console.WriteLine(n * i);
        }

    }
}
