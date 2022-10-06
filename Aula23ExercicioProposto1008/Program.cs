using System;
using System.Globalization;

namespace exercicioproposto1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroFuncionaro = int.Parse(Console.ReadLine());
            int horasTrabalhadas = int.Parse(Console.ReadLine());
            double salarioPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double salarioMes = horasTrabalhadas * salarioPorHora;

            Console.WriteLine($"NUMBER = {numeroFuncionaro}");
            Console.WriteLine($"SALARY = U$ {salarioMes:F2}", CultureInfo.InvariantCulture);

            Console.ReadLine();
        }
    }
}
