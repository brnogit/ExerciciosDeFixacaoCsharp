using System;
using System.Globalization;

namespace exercicioproposto1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string vendedor = Console.ReadLine();
            double salarioFixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double totalDeVendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double comissao = totalDeVendas * (15.0/100.0);

            double totalAReceber = salarioFixo + comissao;

            Console.WriteLine($"TOTAL = {totalAReceber:F2}");

            Console.ReadLine();
        }
    }
}