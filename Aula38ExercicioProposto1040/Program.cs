using System;
using System.Globalization;

namespace exercicioproposto1040
{
    class Program
    {
        static void Main(string[] args)
        {
            double notaA, notaB, notaC, notaD, media, notaDoExame;

            string[] notas = Console.ReadLine().Split(' ');
            notaA = double.Parse(notas[0], CultureInfo.InvariantCulture);
            notaB = double.Parse(notas[1], CultureInfo.InvariantCulture);
            notaC = double.Parse(notas[2], CultureInfo.InvariantCulture);
            notaD = double.Parse(notas[3], CultureInfo.InvariantCulture);

            media = ((notaA * 2) + (notaB * 3) + (notaC * 4) + (notaD * 1)) / 10;
            media = Math.Truncate(media * 10)/10;
            Console.WriteLine($"Media: {media:F1}", CultureInfo.InvariantCulture);

            // Se esta média for maior ou igual a 7.0, imprima a mensagem "Aluno aprovado.".
            if(media >= 7.0)
            {
                Console.WriteLine("Aluno aprovado.");
            }
            else if(media < 5.0)
            {
                Console.WriteLine("Aluno reprovado.");
            }
            else if(media >= 5.0 && media <= 6.9)
            {
                Console.WriteLine("Aluno em exame.");

                notaDoExame = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine($"Nota do exame: {notaDoExame:F1}", CultureInfo.InvariantCulture);

                media = (media + notaDoExame) / 2;

                if(media >= 5.0)
                {
                    Console.WriteLine("Aluno aprovado.");
                }
                else if(media <= 4.9)
                {
                    Console.WriteLine("Aluno reprovado.");
                }
                Console.WriteLine($"Media final: {media:F1}", CultureInfo.InvariantCulture);
            }
        }
    }
}