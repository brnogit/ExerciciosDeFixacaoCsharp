using System;
using System.Linq;

namespace exercicioproposto1013
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] valores = Console.ReadLine().Split(' ');
            //List<int> list = valores.Select(int.Parse).ToList();
            //int maiorNumero = list.Max();
            //Console.WriteLine($"{maiorNumero} eh o maior");

            string[] valores = Console.ReadLine().Split(' ');
            int valorA = int.Parse(valores[0]);
            int valorB = int.Parse(valores[1]);
            int valorC = int.Parse(valores[2]);

            int maiorValorAB = (valorA + valorB + Math.Abs(valorA - valorB)) / 2;
            int maiorValorABC = (maiorValorAB + valorC + Math.Abs(maiorValorAB - valorC)) / 2;

            Console.WriteLine($"{maiorValorABC} eh o maior");

        }
    }
}
