using System;

namespace exercicioproposto1115
{
    class Program
    {
        static void Main(string[] args)
        {
            int coodernadaX, coodernadaY;

            string[] vet = Console.ReadLine().Split(' ');
            coodernadaX = int.Parse(vet[0]);
            coodernadaY = int.Parse(vet[1]);

            while(coodernadaX != 0 || coodernadaY != 0)
            {
                if(coodernadaX > 0 && coodernadaY > 0)
                {
                    Console.WriteLine("primeiro");
                }
                else if (coodernadaY > 0 && coodernadaX < 0)
                {
                    Console.WriteLine("segundo");
                }
                else if(coodernadaY < 0 && coodernadaX < 0)
                {
                    Console.WriteLine("terceiro");
                }
                else if(coodernadaY < 0 && coodernadaX > 0)
                {
                    Console.WriteLine("quarto");
                }
                vet = Console.ReadLine().Split(' ');
                coodernadaX = int.Parse(vet[0]);
                coodernadaY = int.Parse(vet[1]);
            }
        }
    }
}
