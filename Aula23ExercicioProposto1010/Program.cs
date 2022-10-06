using System;
using System.Globalization;

namespace exercicioproposto1010
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peca1 = Console.ReadLine().Split(' ');
            int codigoPeca1 = int.Parse(peca1[0]);
            int qntdPeca1 = int.Parse(peca1[1]);
            double valorUnitarioPeca1 = double.Parse(peca1[2], CultureInfo.InvariantCulture);

            string[] peca2 = Console.ReadLine().Split(' ');
            int codigoPeca2 = int.Parse(peca2[0]);
            int qntdPeca2 = int.Parse(peca2[1]);
            double valorUnitarioPeca2 = double.Parse(peca2[2], CultureInfo.InvariantCulture);

            double valorPeca1 = qntdPeca1 * valorUnitarioPeca1;
            double valorPeca2 = qntdPeca2 * valorUnitarioPeca2;

            double valorTotalPecas = valorPeca1 + valorPeca2;

            Console.WriteLine($"VALOR A PAGAR: R$ {valorTotalPecas:F2}", CultureInfo.InvariantCulture);
        }

    }
}
