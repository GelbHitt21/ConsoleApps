using System;

namespace App2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите x:");
                    x = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Введите y:");
                    y = Convert.ToDouble(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число");
                }
            }
            Console.Write("Точка находится ");
            if (x < -40 || x > 40 || y < -40 || y > 40)
                Console.WriteLine("внутри области");
            else if (x == -40 || x == 40 || y == -40 || y == 40)
                Console.WriteLine("на границе области");
            else if (x > -40 || x < 40 || y > -40 || y < 40)
                Console.WriteLine("вне области");
        }
    }
}


