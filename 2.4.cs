using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите число");
        int n;
        n = int.Parse(Console.ReadLine());
        int i;
        int a=1;
        for (i = 1; i <=n; i++)
        {
            a = i*a;

        }
        Console.WriteLine(a);

    }

}