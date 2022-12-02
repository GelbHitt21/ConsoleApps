using System;

namespace app1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x1, x2, x3, y1, y2, y3;
            double a, b, c, p, res;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите координаты A:");
                    x1 = Convert.ToInt32(Console.ReadLine());
                    y1 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число"); 
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите координаты B:");
                    x2 = Convert.ToInt32(Console.ReadLine());
                    y2 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число");
                }
            }
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите координаты С:");
                    x3 = Convert.ToInt32(Console.ReadLine());
                    y3 = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число");
                }
            }
            a = Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
            b = Math.Sqrt(Math.Pow(x3 - x2, 2) + Math.Pow(y3 - y2, 2));
            c = Math.Sqrt(Math.Pow(x1 - x3, 2) + Math.Pow(y1 - y3, 2));
            if(a==0||b==0||c==0)
            {
                Console.WriteLine("Такого треугольника не существует");
            }
            else
            {
            p = (a + b + c) / 2;

            res = Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            Console.WriteLine("Площадь треугольника ABC равна:" + res);
            }
        }
    }
}



