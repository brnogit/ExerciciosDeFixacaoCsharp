using System;

namespace exercicioproposto1067
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX;
            valorX = int.Parse(Console.ReadLine());

            for(int i = 0; i <= valorX; i++)
            {
                if(i % 2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
