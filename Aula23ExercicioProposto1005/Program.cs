using System;
using System.Globalization;

namespace exercicioproposto1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double valorB = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            double mediaDoAluno = ((valorA * 3.5) + (valorB * 7.5)) / 11;

            Console.WriteLine($"MEDIA = {mediaDoAluno:F5}", CultureInfo.InvariantCulture);
        }
    }
}