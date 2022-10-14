using System;

namespace exercicioproposto1046
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaDeInicio, horaDeFim, diferenca; 

            string[] valores = Console.ReadLine().Split(' ');
            horaDeInicio = int.Parse(valores[0]);
            horaDeFim = int.Parse(valores[1]);

            

            if( horaDeInicio >= horaDeFim)
            {
                diferenca = 24 - (horaDeInicio - horaDeFim);
            } else
            {
                diferenca = horaDeFim - horaDeInicio;
            }

            Console.WriteLine($"O JOGO DUROU {diferenca} HORA(S)");
        }
    }
}
