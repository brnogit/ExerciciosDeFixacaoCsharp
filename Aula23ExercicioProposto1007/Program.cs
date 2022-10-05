using System;

namespace exercicioproposto1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA = int.Parse(Console.ReadLine());
            int valorB = int.Parse(Console.ReadLine());
            int valorC = int.Parse(Console.ReadLine());
            int valorD = int.Parse(Console.ReadLine());

            int diferenca = (valorA * valorB) - (valorC * valorD);

            Console.WriteLine($"DIFERENCA = {diferenca}");

            Console.ReadLine();
        }
    }
}
