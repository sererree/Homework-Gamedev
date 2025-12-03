using System;
internal class Program
{
    static void Main(string[] args)
    {
        int [] a= new int[10] {1,2,3,4,5,0,0,0,0,0};
        int i;
        int count = 5;
        int j;
        int f;
        
        
        for (i=4; i<a.Length-1;i++)
        {
            a[i + 1] = 2 * i;
            count++;
            string m = string.Join(" ", a);
            Console.WriteLine(m);
        }
        
        

        if (count == 10)
        {
            int[] new_a = new int[a.Length * 2];
            for (j = 0; j < a.Length; j++)
            {
                new_a[j] = a[j];
                
            }

            string s = string.Join(" ", new_a);
            Console.WriteLine(s);
        }
       
        




    }
}
