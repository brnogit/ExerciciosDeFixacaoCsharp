using System;
using System.Globalization;

namespace exercicioproposto1048
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            double novoSalario, valorDoReajuste, porcentagem;
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if(salario > 0 && salario <= 400.00)
            {
                porcentagem = 15;
                novoSalario = salario + (salario * (porcentagem / 100.0));
                valorDoReajuste = novoSalario - salario;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {valorDoReajuste:F2}");
                Console.WriteLine($"Em percentual: {porcentagem} %");
            }
            if(salario >= 400.01 && salario <= 800.00)
            {
                porcentagem = 12;
                novoSalario = salario + (salario * (porcentagem / 100.0));
                valorDoReajuste = novoSalario - salario;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {valorDoReajuste:F2}");
                Console.WriteLine($"Em percentual: {porcentagem} %");
            }
            if (salario >= 800.01 && salario <= 1200.00)
            {
                porcentagem = 10;
                novoSalario = salario + (salario * (porcentagem / 100.0));
                valorDoReajuste = novoSalario - salario;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {valorDoReajuste:F2}");
                Console.WriteLine($"Em percentual: {porcentagem} %");
            }
            if (salario >= 1200.01 && salario <= 2000.00)
            {
                porcentagem = 7;
                novoSalario = salario + (salario * (porcentagem / 100.0));
                valorDoReajuste = novoSalario - salario;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {valorDoReajuste:F2}");
                Console.WriteLine($"Em percentual: {porcentagem} %");
            } else if (salario > 2000.00)
            {
                porcentagem = 4;
                novoSalario = salario + (salario * (porcentagem / 100.0));
                valorDoReajuste = novoSalario - salario;

                Console.WriteLine($"Novo salario: {novoSalario:F2}");
                Console.WriteLine($"Reajuste ganho: {valorDoReajuste:F2}");
                Console.WriteLine($"Em percentual: {porcentagem} %");
            }

            
        }
    }
}