using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[5] { 1, 2, 3, 4, 5 };
        int i;
        int c = 1;
        int[] b = new int[5];
        for (i =0; i < a.Length; i++)
        {
            b[i] = a[a.Length-c];
            c++;
        }
        
       
        
        string s = string.Join(" ", b);
        Console.WriteLine(s);
    }
}

