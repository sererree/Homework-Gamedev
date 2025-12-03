using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[5];
        int i;
        int f;
        int count=1;
        Console.WriteLine("Введите пять чисел");
        for (i =0; i<a.Length; i++)
        {
            f = int.Parse(Console.ReadLine());
            a[i] = f;
        }
        string s = string.Join(" ", a);
        Console.WriteLine(s);

        for (i=0; i<a.Length-1; i++)
        {
            if (a[i] == a[i+1])
            {
                a[i] = 0;
            }
            if (a[i]!=0)
            {
                count++;
                Console.WriteLine(count);
            }
        }
        int[] a1 = new int[count];
        int y=0;
        for (i=0; i<a.Length-1; i++)
        {
            if (a[i] != 0)
            {
                a1[y] = a[i];
                y++;
            }

        }
        a1[a1.Length-1] = a[4];
        string m = string.Join(" ", a1);
        Console.WriteLine(m);
        
       
    }


        

}
