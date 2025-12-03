using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[5] { 1, 1, 1, 4, 5 };
        Console.WriteLine("Введите число которое хотите удалить");
        int deletedchislo = int.Parse(Console.ReadLine());

        int i;
        for (i = 0; i < a.Length-1; i++)
        {
            if (a[i] == deletedchislo)
            {
                a[i] = 0;
            }
            
        }

        string s = string.Join(" ", a);
        Console.WriteLine(s);

    }

}



