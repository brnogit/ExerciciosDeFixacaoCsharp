using System;

namespace exercicioproposto1154
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade, contador, idadeTotal;
            double mediaIdade;

            contador = 0;
            idadeTotal = 0;

            idade = int.Parse(Console.ReadLine());
            while(idade >= 0)
            {
                idadeTotal = idadeTotal + idade;
                contador++;
                idade = int.Parse(Console.ReadLine());
            }
            mediaIdade = (double)idadeTotal / contador;
            Console.WriteLine(mediaIdade.ToString("F2"));
        }
    }
}