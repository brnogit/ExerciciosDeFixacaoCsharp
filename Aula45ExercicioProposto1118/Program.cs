using System;
using System.Globalization;

namespace exercicioproposto1118
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media, novoCalculo;
            novoCalculo = 1;

            while (novoCalculo == 1) 
            {
                
                nota1 = 0;
                nota2 = 0;
                media = 0;

                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota1 < 0.0 || nota1 > 10.0)
                {
                    Console.WriteLine("nota invalida");
                    nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }

                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while (nota2 < 0 || nota2 > 10)
                {
                    Console.WriteLine("nota invalida");
                    nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }


                media = (nota1 + nota2) / 2;
                Console.WriteLine($"media = {media:f2}");
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                novoCalculo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                while(novoCalculo < 0 || novoCalculo > 2)
                {
                    Console.WriteLine("novo calculo (1-sim 2-nao)");
                    novoCalculo = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                }
            }
        }
    }
}

