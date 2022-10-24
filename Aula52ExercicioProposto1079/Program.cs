using System;
using System.Globalization;

namespace exercicioproposto1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN;
            double valorUm, valorDois, valorTres, media;
            valorN = int.Parse(Console.ReadLine());


            valorUm = 0;
            valorDois = 0;
            valorTres = 0;
            media = 0;


            for(int i = 0; i < valorN; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                valorUm = double.Parse(valores[0], CultureInfo.InvariantCulture);
                valorDois = double.Parse(valores[1], CultureInfo.InvariantCulture);
                valorTres = double.Parse(valores[2], CultureInfo.InvariantCulture);

                media = (valorUm * 2.0 + valorDois * 3.0 + valorTres * 5.0) / 10.0 ;
                Console.WriteLine(media.ToString("F1"));
            }
        }
    }
}