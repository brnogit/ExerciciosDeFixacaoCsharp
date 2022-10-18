using System;
using System.Globalization;

namespace exercicioproposto1051
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDoImposto8, valorDoImposto18, valorDoImposto28, totalImposto;
            double renda = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(renda<= 2000.00)
            {
                Console.WriteLine("Isento");
            }
            else if(renda >= 2000.01 && renda <= 3000.00)
            {
                
                totalImposto = (renda - 2000) * 0.08;
                Console.WriteLine($"R$ {totalImposto:F2}");
            }
            else if(renda >= 3000.01 && renda <= 4500.00)
            {
                
                valorDoImposto8 = 1000.00 * 0.08;
                renda = renda - 3000.00;
                valorDoImposto18 = renda * 0.18;
                totalImposto = valorDoImposto8 + valorDoImposto18;

                Console.WriteLine($"R$ {totalImposto:F2}");
            }
            else
            {
                valorDoImposto8 = 1000.00 * 0.08;
                valorDoImposto18 = 1500.00 * 0.18;
                renda = renda - 4500.00;
                valorDoImposto28 = renda * 0.28;
                totalImposto = valorDoImposto8 + valorDoImposto18 + valorDoImposto28;

                Console.WriteLine($"R$ {totalImposto:F2}");

            }
        }
    }
}