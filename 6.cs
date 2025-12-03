using System;

internal class Programm
{
    static void Main(string[] args)
    {
        int[] a = new int[6] { 1, 2, 3, 4, 5, 6 };
        int count = 0;
        int i;
        for (i=0;i<=a.Length-1;i++)
        {
            if (a[i] % 2 ==0)
            {
                count++;
            }
        }
        Console.WriteLine(count);
        Console.ReadKey();
    }
}

