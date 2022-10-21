using System;

int golInter, golGremio, grenal;

grenal = 1;

while (grenal == 1)
{
    string[] gols = Console.ReadLine().Split(' ');
    golInter = int.Parse(gols[0]);
    golGremio = int.Parse(gols[1]);

    Console.WriteLine("Novo grenal (1-sim 2-nao");
    grenal = int.Parse(Console.ReadLine());
}



