using System;

internal class Programm
{
    static void Main(string[] args)
    {
        int[] a = new int[4] { 1, 2, 3, 4};
        int i_1 = a[0];
        int i_3 = a[3];
        a[0] = i_3;
        a[3] = i_1;
        string s = string.Join(" ", a);
        Console.WriteLine(s);

        
    }
}
