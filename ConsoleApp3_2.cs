using System;

namespace App3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, m;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число:");
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число");
                }
            }
            if (n > 9 && n < 100)
            {
                string str = Convert.ToString(n);
                char[] arr = str.ToCharArray();
                Array.Reverse(arr);
                str = new string(arr);
                m = Convert.ToInt32(str);
                Console.WriteLine("Результат:");
                Console.WriteLine(m);
            }
            else
            {
                Console.WriteLine(n);
            }
        }
    }
}
