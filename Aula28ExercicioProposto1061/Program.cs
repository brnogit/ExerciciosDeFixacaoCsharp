using System;

namespace exercicioproposto1061
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, horas, minutos, segundos, diaInicial, horaInicial, minutoInicial, segundoInicial, tempoInicialEmSegundos, diaFinal, horaFinal, minutoFinal, segundoFinal, tempoFinalEmSegundos, diferencaDoValor;
            
            // Primeiro todos valores são convertidos em inteiros
            string[] dataInicio = Console.ReadLine().Split(' ');
            diaInicial = int.Parse(dataInicio[1]);

            string[] horarioInicio = Console.ReadLine().Split(':');
            horaInicial = int.Parse(horarioInicio[0]);
            minutoInicial = int.Parse(horarioInicio[1]);
            segundoInicial = int.Parse(horarioInicio[2]);

            //é transformado todo o tempo em segundos
            tempoInicialEmSegundos = diaInicial*24*60*60 + horaInicial * 60 * 60 + minutoInicial * 60 + segundoInicial;

            string[] dataFim = Console.ReadLine().Split(' ');
            diaFinal = int.Parse(dataFim[1]);

            string[] horarioFim = Console.ReadLine().Split(':');
            horaFinal = int.Parse(horarioFim[0]);
            minutoFinal = int.Parse(horarioFim[1]);
            segundoFinal = int.Parse(horarioFim[2]);

            //é transformado todo o tempo em segundos
            tempoFinalEmSegundos = diaFinal * 24 * 60 * 60 + horaFinal * 60 * 60 + minutoFinal * 60 + segundoFinal;

            //o tempo em segundos facilita o calculo, assim achando a diferenca entre tempo inicial e final
            diferencaDoValor = tempoFinalEmSegundos - tempoInicialEmSegundos;

            //depois é feito a divisão para converter de volta o tempo de segundos em dias, horas, minutos e segundos.
            dias = diferencaDoValor / (24 * 60 * 60);
            diferencaDoValor = diferencaDoValor % (24 * 60 * 60);

            horas = diferencaDoValor / (60 * 60);
            diferencaDoValor = diferencaDoValor % (60 * 60);

            minutos = diferencaDoValor / 60;
            diferencaDoValor = diferencaDoValor % 60;

            segundos = diferencaDoValor;

            Console.WriteLine($"{dias} dia(s)");
            Console.WriteLine($"{horas} hora(s)");
            Console.WriteLine($"{minutos} minuto(s)");
            Console.WriteLine($"{segundos} segundo(s)");
        }
    }
}