using System;
using System.Globalization;

namespace exercicioproposto1014
{
    class Program
    {
        static void Main(string[] argfs)
        {
            int distanciaTotalX = int.Parse(Console.ReadLine());
            double totalDeCombustivelGastoY = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double consumoMedioDoAutomovel = distanciaTotalX / totalDeCombustivelGastoY;

            Console.WriteLine($"{consumoMedioDoAutomovel:F3} km/l", CultureInfo.InvariantCulture);
        }
    }
}
