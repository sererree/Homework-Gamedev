using System;

internal class Programm
{
    static void Main(string[] args)
    {
        int[] a = new int[5] { 1, 2, 7, 4, 5 };
        int max_value = a[0];
        int min_value = a[0];

        int min_ind = 0;
        int max_ind = 0;

        int i;
        for (i=1; i<a.Length; i++)
        {
            if (min_value > a[i])
            {
                min_value = a[i];
                min_ind = i;
            }
            if (max_value < a[i])
            {
                max_value = a[i];
                max_ind = i;
            }
        }
        Console.WriteLine($"{max_value},{min_value}");
        Console.WriteLine($"{max_ind},{min_ind}");
    }
}


