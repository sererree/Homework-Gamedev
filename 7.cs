using System;

internal class Programm
{
    static void Main(string[] args)
    {
        int[] a = new int[6] { 1, 2, 3, 4, 5, 6 };
        int summ = 0;
        int sred_ar = 0;
        int i;
        for (i=0; i < a.Length; i++)
        {
            summ += a[i];

        }
        sred_ar = summ / a.Length;
        Console.WriteLine($"{summ},{(float)summ / a.Length}");
    }
}
