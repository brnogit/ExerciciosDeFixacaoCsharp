using System;

namespace exercicioproposto1047
{
    class Program
    {
        static void Main(string[] args)
        {
            int horaInicial, minutoInicial, horaFinal, minutoFinal, duracaoDoJogo, tempoInicialEmMinutos, tempoFinalEmMinutos, diferenca, horas, minutos;

            string[] valores = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(valores[0]);
            minutoInicial = int.Parse(valores[1]);
            horaFinal = int.Parse(valores[2]);
            minutoFinal = int.Parse(valores[3]);

            tempoInicialEmMinutos = (horaInicial * 60) + minutoInicial;
            tempoFinalEmMinutos = (horaFinal * 60) + minutoFinal;

            
            if(tempoInicialEmMinutos >= tempoFinalEmMinutos)
            {
                diferenca = (24 * 60) - (tempoInicialEmMinutos - tempoFinalEmMinutos);
            } 
            else{
                diferenca = tempoFinalEmMinutos - tempoInicialEmMinutos;    
            }

            horas = diferenca / 60;
            minutos = diferenca % 60;
            Console.WriteLine($"O JOGO DUROU {horas} HORA(S) E {minutos} MINUTO(S)");
        }
    }
}