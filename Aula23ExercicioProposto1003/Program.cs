using System;

namespace exercicioproposto1003
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA = int.Parse(Console.ReadLine());
            int valorB = int.Parse(Console.ReadLine());


            int soma = valorA + valorB;

            Console.WriteLine($"SOMA = {soma}");

            Console.ReadLine();
        }
    }
}