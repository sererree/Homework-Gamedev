using System;
internal class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("введите число");
        n = int.Parse(Console.ReadLine());
        int i;
        int a = 0;
        for (i=1; i<=n; i++)
        {
            a = a+i;
        }
        Console.WriteLine(a);
    }
}
