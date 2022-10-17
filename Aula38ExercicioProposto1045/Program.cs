using System;
using System.Globalization;

namespace exercicioproposto1045
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorA, valorB, valorC, maior, medio,menor;

            string[] valores = Console.ReadLine().Split(' ');
            valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if(valorA >= valorB && valorA >= valorC)
            {
                maior = valorA;
                medio = valorB;
                menor = valorC;
            }
            else if(valorB >= valorA && valorB >= valorC)
            {
                maior = valorB;
                medio = valorA;
                menor = valorC;
            } else
            {
                maior = valorC;
                medio = valorA;
                menor = valorB;
            }




            if(maior >= (medio + menor))
            {
                Console.WriteLine("NAO FORMA TRIANGULO");
            } 
            else if(Math.Pow(maior,2) == (Math.Pow(medio, 2) + Math.Pow(menor, 2)))
            {
                Console.WriteLine("TRIANGULO RETANGULO");
            }
            else if(Math.Pow(maior, 2) > (Math.Pow(medio, 2) + Math.Pow(menor, 2)))
            {
                Console.WriteLine("TRIANGULO OBTUSANGULO");
            }
            else if(Math.Pow(maior, 2) < (Math.Pow(medio, 2) + Math.Pow(menor, 2)))
            {
                Console.WriteLine("TRIANGULO ACUTANGULO");
            }

            if(maior == medio && maior == menor)
            {
                Console.WriteLine("TRIANGULO EQUILATERO");
            } else if ((maior == medio && maior !=  menor) || (maior == menor && maior != medio) || (medio == menor && medio != maior))
            {
                Console.WriteLine("TRIANGULO ISOSCELES");
            }
        }
    }
}
