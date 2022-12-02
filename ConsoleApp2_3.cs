using System;

namespace App2_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Введите a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("while:");
            while (a <= b)
            {
                if (a % 2 == 0)
                    Console.Write("{0} ", a);
                a++;
            }
            Console.WriteLine();
            Console.WriteLine("do...while:");
            do
            {
                if (a % 2 == 0)
                    Console.Write("{0} ", a);
                a++;
            }
            while (a <= b);
            Console.WriteLine();
            Console.WriteLine("for:");
            for (int i = a; i <= b; i++)
            {
                if (i % 2 == 0)
                    Console.Write("{0} ", i);
            }
        }
    }
}

