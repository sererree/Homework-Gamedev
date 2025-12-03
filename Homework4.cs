using System;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Задание 1, введи число, модуль которого хочешь получить");
        number_1();

        Console.WriteLine("Задание 2, введи три числа");
        number_2();

        Console.WriteLine("Задание 3");
        number_3();

        Console.WriteLine("Задание 4");
        number_4();

        Console.WriteLine("Задание 5");
        number_5();

        Console.WriteLine("Задание 6");
        number_6();

        Console.WriteLine("Задание 7");
        number_7();


        Console.WriteLine("Задание 8");
        number_8();

        Console.WriteLine("Задание 9");
        number_9();

        Console.WriteLine("Задание 10");
        number_10();

        Console.WriteLine("Задание 11");
        number_11();
       

        Console.ReadKey();
    }



    //задание 1
    static double Abs(double x)
    {
        
        if (x>=0)
        {
            return x;
        }
        else
        {
            return x * -1;
        }
        
    }
    static void number_1()
    {
        if (int.TryParse(Console.ReadLine(), out int number1))
        {
            Console.WriteLine(Abs(number1));

        }
        else
        {
            Console.WriteLine("Это не число");
        }
    }

    //задание 2
    static int Max3(int a,int b,int c)
    {
        if (a>b)
        {
            if (a>c)
            {
                return a;
            }
        }

        if (b > a)
        {
            if (b > c)
            {
                return b;
            }
        }

        if (c > a)
        {
            if (c> b)
            {
                return c;
            }
        }
        return 0;
    
    }

    static void number_2()
    {
        if (int.TryParse(Console.ReadLine(), out int number2_1))
        {
            int num2_1 = number2_1;

        }
        else
        {
            Console.WriteLine("Это не число");

        }

        if (int.TryParse(Console.ReadLine(), out int number2_2))
        {
            int num2_2 = number2_2;

        }
        else
        {
            Console.WriteLine("Это не число");
        }

        if (int.TryParse(Console.ReadLine(), out int number2_3))
        {
            int num2_3 = number2_3;

        }
        else
        {
            Console.WriteLine("Это не число");
        }


        Console.WriteLine("Наибольшее число:");
        Console.WriteLine(Max3(number2_1, number2_2, number2_3));

    }


    //задание 3
    static void PrintLine(string symbol = "*", int count = 10)
    {
        int i;

        for (i=0; i<count; i++)
        {
            Console.Write(symbol);
        }
        Console.WriteLine();
            
    }

    static void number_3()
    {
        Console.WriteLine("Введите строку, которую хотите вывести");
        string vvod = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите, сколько раз вывести строку");
        if (int.TryParse(Console.ReadLine(), out int number_3))
        {
            int num_3 = number_3;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
        PrintLine(vvod, number_3);

    }


    //задание 4
    static string Repeat(string text, int times = 10)
    {
        int i;

        for (i = 0; i < times; i++)
        {
            return text;
        }
        return null;
        

    }

    static void number_4()
    {
        Console.WriteLine("Введите строку, которую хотите вывести");
        string vvod = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Введите, сколько раз вывести строку");
        if (int.TryParse(Console.ReadLine(), out int number_4))
        {
            int num_4 = number_4;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
        PrintLine(vvod, number_4);
        
    }

    //задание 5
    static bool TryIndexOff(string s,char ch, out int index)
    {
        int i;
        index = 0;
        for (i=0; i< s.Length;i++)
        {
            index = -1;
            if (s[i] == ch)
            {
                index = s[i];
                return true;

            }
            
        }
        return false;
        
    }

    static void number_5()
    {
        Console.WriteLine("введите строку, чтобы проверить есть ли в ней символ k");
        string vvod = Convert.ToString(Console.ReadLine());
        char ch = 'k';
        Console.WriteLine(TryIndexOff(vvod, ch , out int index));
    }


    //задание 6
    static int Clamp(ref int value,int min, int max)
    {
        if (value<min)
        {
            value = min;
            return value;
        }
        if(value > max)
        {
            value = max;
            return value;
        }
        return 0;
    }

    static void number_6()
    {
        Console.WriteLine("Введите минимальное и максимальное число в диапазоне");
        if (int.TryParse(Console.ReadLine(), out int min))
        {
            int min6 = min;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
        if (int.TryParse(Console.ReadLine(), out int max))
        {
            int max6 = max;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
        Console.WriteLine("Введите число в пределах диапазона");
        if (int.TryParse(Console.ReadLine(), out int num_6))
        {
            int value = num_6;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
        if (num_6>min)
        {
            Console.WriteLine("Ваше число");
            Console.WriteLine(num_6);
        }
        if (num_6<max)
        {
            Console.WriteLine("Ваше число");
            Console.WriteLine(num_6);
        }
        else
        {
            Console.WriteLine("Ваше число");
            Console.WriteLine(Clamp(ref num_6, min, max));
        }
    }

    //задание 7
    static string ReverseRec(string s)
    {
        return Reverse(s, 0);
    }
    static string Reverse(string s,int index)
    {
       if(index>=s.Length)
        {
            return "";
        }
        return Reverse(s, index + 1) + s[index];
    }
    static void number_7()
    {
        Console.WriteLine("Введи строку которую нужно первернуть");
        string s = Console.ReadLine();
        Console.WriteLine(ReverseRec(s));


    }


    //8
    static int SumDigitsRec(int n)
    {
        if (n<0)
        {
            n = n * -1;
        }

        if (n<10)
        {
            return n;
        }

        return (n % 10 + SumDigitsRec(n / 10));
    }

    static void number_8()
    {
        Console.WriteLine("Введите число");
        if (int.TryParse(Console.ReadLine(), out int n))
        {
            Console.WriteLine(SumDigitsRec(n));
        }
        else
        {
            Console.WriteLine("Это не число");
        }
        
    }



    //9
    static bool IsTriangle(in int a, in int b, in int c)
    {
        if (a + b > c)
        {
            return true;
        }
        if (a + c > b)
        {
            return true;
        }
        if (c + b > a)
        {
            return true;
        }
        return false;
    }

    static void number_9()
    {

        Console.WriteLine("Введите стороны треугольника");
        if (int.TryParse(Console.ReadLine(), out int a))
        {
            int a_9 = a;
        }
        else
        {
            Console.WriteLine("Это не число");
        }

        if (int.TryParse(Console.ReadLine(), out int b))
        {
            int b_9 = b;
        }
        else
        {
            Console.WriteLine("Это не число");
        }


        if (int.TryParse(Console.ReadLine(), out int c))
        {
            int c_9 = c;
        }
        else
        {
            Console.WriteLine("Это не число");
        }
        Console.WriteLine((IsTriangle(a, b, c)));
    }

    //10
    static int count_1 = 0;
    static int count_2 = 0;
    static int Powfast(int a, int n)
    {
        count_1++;
        if (n==0)
        {
            return 1;
        }
        if (n==1)
        {
            return a;
        }
        if(a==1)
        {
            return 1;
        }
        if (a==0)
        {
            return 0;
        }


        if (n % 2 == 0)
        {
            int n_1 =  Powfast(a, n/2);
            n_1 *= n_1;
            return n_1;
            

        }
        if (n%2!=0)
        {
            return a * Powfast(a, n - 1);
            
        }
        return 0;

    }

    static int PowRec(int a,int n)
    {
        count_2++;
        if (n == 0)
        {
            return 1;
        }
        if (n == 1)
        {
            return a;
        }
        if (a == 1)
        {
            return 1;
        }
        if (a == 0)
        {
            return 0;
        }


        return a * PowRec(a, n - 1);
        
    }

    static void number_10()
    {
        Console.WriteLine("ВВедите число и степень");
        if (int.TryParse(Console.ReadLine(),out int a))
        {
            if ((int.TryParse(Console.ReadLine(), out int n)))
            {
                Console.WriteLine(Powfast(a, n));
                Console.WriteLine($"Кол-во шагов,{count_1}");
                Console.WriteLine(PowRec(a, n));
                Console.WriteLine($"Кол-во шагов,{count_2}");

            }
        }
       else
        {
            Console.WriteLine("Это не число");
        }

    }


    //задание 11
    static string CompressRuns(string s)
    {
        int i;
        string news = "";
        news = news + s[0];

        for (i = 0; i < s.Length-1; i++)
        {
            if (s[i] != s[i+1])
            {
                news = news + s[i+1];
            }

        }
        return news;
    }
    static void number_11()
    {
        Console.WriteLine("Введи строку");
        string s = Console.ReadLine();
        Console.WriteLine(CompressRuns(s));

    }

}


