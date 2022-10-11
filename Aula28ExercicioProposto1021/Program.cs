using System;
using System.Globalization;
using System.Collections.Generic;


namespace exercicioproposto1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double quantidadeNotas, quantidadeMoedas;
            int inteiros;
            
            double valorMonetario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            List<double> lista = new List<double> { 100, 50, 20, 10, 5, 2};
            List<double> listaMoeda = new List<double> { 1, 0.50, 0.25, 0.10, 0.05, 0.01};

            Console.WriteLine("NOTAS:");
            foreach (double notas in lista)
            {
                    quantidadeNotas = valorMonetario / notas;
                    inteiros = (int)quantidadeNotas;
                    Console.WriteLine($"{inteiros} nota(s) de R$ {notas:F2}", CultureInfo.InvariantCulture);
                    valorMonetario = valorMonetario % notas;
            }

            Console.WriteLine("MOEDAS:");
            foreach (double moedas in listaMoeda)
            {
                    quantidadeMoedas = Math.Round(valorMonetario, 2) / moedas;
                    inteiros = (int)quantidadeMoedas;
                    Console.WriteLine($"{inteiros} moeda(s) de R$ {moedas:F2}", CultureInfo.InvariantCulture);
                    valorMonetario = valorMonetario % moedas;
            }
            
        }
    }
}
