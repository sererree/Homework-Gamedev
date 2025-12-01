using System;
internal class Program
{
    static void Main(string[] args)
    {
        string password = "timosha";
        string a;
        Console.WriteLine("Введите пароль");
        a = Console.ReadLine();
        while (a != password)
        {
            Console.WriteLine("Пароль неправильный");
            Console.WriteLine("Введите пароль");
            a = Console.ReadLine();
            if (a == password)
            {
                Console.WriteLine("Пароль верный");
            }
        }

    }
        
}
