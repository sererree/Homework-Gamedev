using System;

internal class Programm
{
    static void Main(string[] args)
    {
        int[] a = new int[5] {1,2,3,4,5};
        string m = string.Join(", ", a);
        Console.WriteLine(m);

    }
}

