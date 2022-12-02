using System;

namespace App1_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, a, sum;
            Console.WriteLine("Двузначное число: ");
            while (true)
            {
                try
                {
                    num = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число"); 
                }
            }
            Console.WriteLine("Число A: ");
            while (true)
            {
                try
                {
                    a = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число"); 
                }
            }
            sum = num % 10 + (num / 10) % 10;
            Console.WriteLine((sum % a) == 0 ? "Кратно" : "Не кратно");
        }
    }
}
