using System;
using System.Collections.Generic;

namespace exercicioproposto1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int idadeAno, idadeMes, idadeDias, restoDaIdade;

            int idadeDaPessoaEmDias = int.Parse(Console.ReadLine());

            idadeAno = idadeDaPessoaEmDias / 365;
            restoDaIdade = idadeDaPessoaEmDias % 365;

            idadeMes = restoDaIdade / 30;
            idadeDias = restoDaIdade % 30;


            Console.WriteLine($"{idadeAno} ano (s)");
            Console.WriteLine($"{idadeMes} mes (es)");
            Console.WriteLine($"{idadeDias} dia (s)");
        }
    }
}
