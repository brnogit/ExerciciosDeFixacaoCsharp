using System;

namespace exercicioproposto1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN;
            valorN = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10000; i++)
            {
                if (i % valorN == 2)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}