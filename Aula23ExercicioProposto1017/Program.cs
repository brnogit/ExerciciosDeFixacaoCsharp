using System;


namespace exercicioproposto1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double consumoPorLitroKm = 12;

            double tempoGastoNaViagem = double.Parse(Console.ReadLine());
            double velocidadeMedia = double.Parse(Console.ReadLine());


            double litrosNecessarios = (velocidadeMedia / consumoPorLitroKm) * tempoGastoNaViagem;


            Console.WriteLine($"{litrosNecessarios:F3}");
        }
    }
}