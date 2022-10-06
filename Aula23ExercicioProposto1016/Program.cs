using System;

namespace exercicioproposto1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distanciaEmKm = int.Parse(Console.ReadLine());

            int tempoParaDistanciar = distanciaEmKm * 2;

            Console.WriteLine($"{tempoParaDistanciar} minutos");
        }
    }
}
