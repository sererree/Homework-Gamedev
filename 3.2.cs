using System;
internal class Program
{
    static void Main(string[] args)
    {
        int n;
        Console.WriteLine("введите число");
        n = int.Parse(Console.ReadLine());
        int i;
        for (i=1; i<=n; i++)
        {
            if (i%2==0)
            {
                Console.WriteLine(i);

            }
            if (i%3==0)
            {
                Console.WriteLine(i);
            }
        }

    }
}
