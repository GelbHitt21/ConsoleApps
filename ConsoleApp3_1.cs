using System.Dynamic;
using System;

namespace App3_2
{
    class Program
    {
        static double F (double x)
        {
            double y;
            if (x <= 5) y = Math.Pow(x, 2) + 5;
            else if (x > 5 && x < 20) y = 0;
            else y = 1;
            return y;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("a=");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("b=");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("h=");
            double h = Convert.ToDouble(Console.ReadLine());
            for (double i = a; i <= b; i += h)
                Console.WriteLine("f({0:f2})={1:f4}", i, F(i));
        }
    }
}
