using System;

namespace exercicioproposto1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN, valorX;
            valorN = int.Parse(Console.ReadLine());

            for(int i = 0; i < valorN; i++)
            {
                valorX = int.Parse(Console.ReadLine());
                if( valorX % 2 == 0 && valorX > 0)
                {
                    Console.WriteLine("EVEN POSITIVE");
                }
                else if(valorX % 2 == 1 && valorX > 0)
                {
                    Console.WriteLine("ODD POSITIVE");
                }
                else if( valorX % 2 == 0 && valorX < 0)
                {
                    Console.WriteLine("EVEN NEGATIVE");
                }
                else if( valorX % 2 == -1 && valorX < 0)
                {
                    Console.WriteLine("ODD NEGATIVE");
                }
                else if(valorX == 0)
                {
                    Console.WriteLine("NULL");
                }
            }
        }
    }
}
