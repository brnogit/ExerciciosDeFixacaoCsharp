using System;
using System.Globalization;

namespace exercicioproposto1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] x1y1 = Console.ReadLine().Split(' ');
            double valorX1 = double.Parse(x1y1[0], CultureInfo.InvariantCulture);
            double valorY1 = double.Parse(x1y1[1], CultureInfo.InvariantCulture);

            string[] x2y2 = Console.ReadLine().Split(' ');
            double valorX2 = double.Parse(x2y2[0], CultureInfo.InvariantCulture);
            double valorY2 = double.Parse(x2y2[1], CultureInfo.InvariantCulture);

            double valorParaRaizQuadrada = Math.Pow(valorX2 - valorX1, 2.0) + Math.Pow(valorY2 - valorY1, 2.0);
            double distancia = Math.Sqrt(valorParaRaizQuadrada);

            Console.WriteLine(distancia.ToString("F4"));

            Console.ReadLine();
        }
    }
}
