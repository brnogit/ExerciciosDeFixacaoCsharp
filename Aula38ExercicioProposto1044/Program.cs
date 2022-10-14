using System;

namespace exercicioproposto1044
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB;

            string[] valores = Console.ReadLine().Split(' ');
            valorA = int.Parse(valores[0]);
            valorB = int.Parse(valores[1]);

            if(valorA % valorB == 0 || valorB % valorA == 0)
            {
                Console.WriteLine("Sao Multiplos");
                
            } else
            {
                
                Console.WriteLine("Nao sao Multiplos");
            }
            

        }
    }
}