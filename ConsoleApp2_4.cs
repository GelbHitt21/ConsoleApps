using System;

namespace App2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 5;
            for (int i = 1; i <= num; i++)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write(j + " ");
                }
                Console.WriteLine();
            }
        }
    }
}

