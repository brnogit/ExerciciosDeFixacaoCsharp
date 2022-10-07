using System;
using System.Globalization;

namespace exercicioproposto1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double pi = 3.14159;

            double raioDaEsfera = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double formulaVolumeDaEsfera = (4 / 3.0) * pi * Math.Pow(raioDaEsfera, 3);

            Console.WriteLine($"VOLUME = {formulaVolumeDaEsfera:F3}", CultureInfo.InvariantCulture);
        }
    }
}
