using System;

namespace exercicioproposto1041
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorX, valorY;

            string[] valores = Console.ReadLine().Split(' ');
            valorX = double.Parse(valores[0]);
            valorY = double.Parse(valores[1]);

            if(valorX > 0 && valorY > 0)
            {
                Console.WriteLine("Q1");
            }
            else if(valorX < 0 && valorY < 0)
            {
                Console.WriteLine("Q3");
            }
            else if( valorX > 0 && valorY < 0)
            {
                Console.WriteLine("Q4");
            }
            else if (valorX < 0 && valorY > 0)
            {
                Console.WriteLine("Q2");
            }
            else if (valorX == 0 && (valorY > 0 || valorY < 0))
            {
                Console.WriteLine("Eixo Y");
            }
            else if (valorY == 0 && (valorX > 0 || valorX < 0))
            {
                Console.WriteLine("Eixo X");
            }
            else
            {
                Console.WriteLine("Origem");
            }
        }
    }
}