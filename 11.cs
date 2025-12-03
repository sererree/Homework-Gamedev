using System;
internal class Program
{

    static void Main(string[] args)
    {
        string s;
        int[] a = new int[5] {1,2,3,4,5};
        int deletedind = 2;
        int[] a2 = new int[5];
        int i;

        int currentIndex = 0;
        for (i = 0; i < a.Length; i++)
        {
            if (i!= deletedind)
            {
                a2[i] = a[i];
                
            }
            
        }
        
        a = a2;
        a[2] = a[3];
        a[3] = a[4];
        a[4] = 0;
        //while (deletedind+1 < a.Length)
        //{
        //    a[deletedind] = a[deletedind + 1];
        //    deletedind++;

        //}

        
        s = string.Join(" ", a);
        Console.WriteLine(s);



    }
}

