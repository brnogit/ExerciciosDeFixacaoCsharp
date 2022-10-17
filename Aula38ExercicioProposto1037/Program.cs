using System;
using System.Globalization;

namespace exercicioproposto1037
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorQualquer = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(valorQualquer >= 25.00001 && valorQualquer <= 50.00000)
            {
                Console.WriteLine($"Intervalo (25,50]");
            }
            else if (valorQualquer >= 0.0 && valorQualquer <= 25.00000)
            {
                Console.WriteLine($"Intervalo [0,25]");
            }
            else if(valorQualquer >= 75.00001 && valorQualquer <= 100.00000)
            {
                Console.WriteLine($"Intervalo (75,100]");
            }
            else
            {
                Console.WriteLine($"Fora de intervalo");
            }
        }
    }
}