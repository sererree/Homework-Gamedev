using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[5] { 1, 2, 3, 4, 5 };
        int deletedind = 2;
        int i;
        for (i =0; i< a.Length; i++)
        {
            if (i!= deletedind)
            {
                a[i] = a[i];
            }
            if (i == deletedind)
            {
                a[deletedind] = a[4];
            }
        }

        string s = string.Join(" ", a);
        Console.WriteLine(s);
       
    }

}

