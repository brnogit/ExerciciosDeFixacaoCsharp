using System;
using System.Globalization;

namespace exercicioproposto1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorB = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorC = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double media = ((valorA * 2) + (valorB * 3) + (valorC * 5)) / 10;

            Console.WriteLine($"MEDIA = {media:F1}", CultureInfo.InvariantCulture);
        }
    }
}
