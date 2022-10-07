using System;
using System.Globalization;

namespace exercicioproposto1012
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double pi = 3.14159;

            string[] valores = Console.ReadLine().Split(' ');
            double valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            //a área do triângulo retângulo que tem A por base e C por altura.
            double areaDoTriangulo = (valorA * valorC) / 2.0;

            // a área do círculo de raio C. (pi = 3.14159)
            double areaDoCirculo = pi * Math.Pow(valorC, 2.0);

            // a área do trapézio que tem A e B por bases e C por altura.
            double areaDoTrapezio = ((valorA + valorB) * valorC) / 2.0;

            // a área do quadrado que tem lado B.
            double areaDoQuadrado = valorB * valorB;

            // a área do retângulo que tem lados A e B.
            double areaDoRetangulo = valorA * valorB;


            Console.WriteLine($"TRIANGULO: {areaDoTriangulo:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"CIRCULO: {areaDoCirculo:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"TRAPEZIO: {areaDoTrapezio:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"QUADRADO: {areaDoQuadrado:F3}", CultureInfo.InvariantCulture);
            Console.WriteLine($"RETANGULO: {areaDoRetangulo:F3}", CultureInfo.InvariantCulture);
        }
    }
}
