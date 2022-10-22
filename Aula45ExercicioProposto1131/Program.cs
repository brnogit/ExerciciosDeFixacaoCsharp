using System;

namespace exercicioproposto1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int golInter, golGremio, grenal, jogos, vitoriaInter, vitoriaGremio, empate;

            vitoriaGremio = 0;
            vitoriaInter = 0;
            empate = 0;

            jogos = 0;
            grenal = 1;

            while (grenal == 1)
            {


                string[] gols = Console.ReadLine().Split(' ');
                golInter = int.Parse(gols[0]);
                golGremio = int.Parse(gols[1]);

                if (golInter > golGremio)
                {
                    vitoriaInter++;
                }
                else if (golGremio > golInter)
                {
                    vitoriaGremio++;
                }
                else if (golInter == golGremio)
                {
                    empate++;
                }


                jogos++;
                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                grenal = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"{jogos} grenais");
            Console.WriteLine($"Inter:{vitoriaInter}");
            Console.WriteLine($"Gremio:{vitoriaGremio}");
            Console.WriteLine($"Empates:{empate}");

            if (vitoriaInter > vitoriaGremio)
            {
                Console.WriteLine("Inter venceu mais");
            }
            if (vitoriaGremio > vitoriaInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            if (vitoriaInter == vitoriaGremio)
            {
                Console.WriteLine("Nao houve vencedor");
            }
        }
    }
}


