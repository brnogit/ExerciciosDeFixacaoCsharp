using System;
using System.Globalization;

namespace ExercicioDeFixacaoAula18
{
    class Program
    {
        static void Main(string[] args)
        {
            // Fazer um programa para executar a seguinte interação com o usuário, lendo os valores destacados em vermelho, e depois mostrar os dados na tela:
            #region Entre com seu nome completo:
            Console.WriteLine("Entre com seu nome completo: ");
            string nomeCompleto = Console.ReadLine();
            #endregion

            #region Quantos quartos tem na sua casa?
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int qtdQuartos = int.Parse(Console.ReadLine());
            #endregion

            #region Entre com o preço de um produto:
            Console.WriteLine("Entre com o preço de um produto: ");
            double precoProduto = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            #endregion

            #region Entre com seu último nome, idade e altura (mesma linha):
            Console.WriteLine("Entre com seu último nome, idade e altura (na mesma linha): ");
            string[] vet = Console.ReadLine().Split(' ');
            string ultimoNome = vet[0];
            int idade = int.Parse(vet[1]);
            double altura = double.Parse(vet[2], CultureInfo.InvariantCulture);
            #endregion

            #region SAÍDA
            Console.WriteLine(nomeCompleto);
            Console.WriteLine(qtdQuartos);
            Console.WriteLine(precoProduto.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(ultimoNome);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));
            #endregion
        }
    }
}