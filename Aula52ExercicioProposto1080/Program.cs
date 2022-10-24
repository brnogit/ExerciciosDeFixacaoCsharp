using System;

namespace exercicioproposto1080
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, maiorValor, posicao;
            valor = 0;
            maiorValor = 0;
            posicao = 0;
            for (int i = 1; i <= 100; i++)
            {
                valor = int.Parse(Console.ReadLine());
                if (valor > maiorValor)
                {
                    maiorValor = valor;
                    posicao = i;
                }
            }
            Console.WriteLine(maiorValor);
            Console.WriteLine(posicao);
        }
    }
}