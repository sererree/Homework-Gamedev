using System;
internal class Program
{
    static void Main(string[] args)
    {
        int[] a = new int[5] {4,3,2,3,5};
        int i;
        int c = 0;
        int[] b = new int[5];
        for (i = 0; i < a.Length; i++)
        {
            if (a[i] == a[a.Length - i-1 ])
            {
                c++;
            }
            
           if (c == a.Length)
            {
                Console.WriteLine("это палиндром");
            }
           
          
        }



      
    }
}


