using System;

namespace exercicioproposto1071
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX, valorY, min, max, soma;

            valorX = int.Parse(Console.ReadLine());
            valorY = int.Parse(Console.ReadLine());

            if(valorX > valorY)
            {
                min = valorY;
                max = valorX;
            } else
            {
                min = valorX;
                max = valorY;
            }

            soma = 0;
            for (int i = min + 1; i < max; i++)
            {
                if(i % 2 != 0)
                {
                    soma = soma + i;
                }
            }
            Console.WriteLine(soma);
        }
    }
}