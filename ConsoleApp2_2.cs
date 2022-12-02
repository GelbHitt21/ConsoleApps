using System;

namespace App2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = new DateTime(1990, 1, 1);
            int m, n;
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите месяцы:");
                    m = Convert.ToInt32(Console.ReadLine());
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
                    Console.WriteLine("Введите дни:");
                    n = Convert.ToInt32(Console.ReadLine());
                    break;
                }
                catch (System.FormatException)
                {
                    Console.WriteLine("Некорректное значение, введите число"); 
                }
            }
            DateTime finish = start.AddMonths(m);
            finish = finish.AddDays(n);
            int month = finish.Month;
            string s_month = "";
            switch (month)
            {
                case 1: s_month = "Январь"; break;
                case 2: s_month = "Февраль"; break;
                case 3: s_month = "Март"; break;
                case 4: s_month = "Апрель"; break;
                case 5: s_month = "Май"; break;
                case 6: s_month = "Июнь"; break;
                case 7: s_month = "Июль"; break;
                case 8: s_month = "Август"; break;
                case 9: s_month = "Сентябрь"; break;
                case 10: s_month = "Октябрь"; break;
                case 11: s_month = "Ноябрь"; break;
                case 12: s_month = "Декабрь"; break;
            }
            Console.WriteLine(s_month);
            Console.ReadLine();
        }
    }
}


