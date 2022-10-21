using System;

namespace exercicioproposto1159
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorX, contador;
            int[] valores = new int[5];

            valorX = int.Parse(Console.ReadLine());

            while(valorX != 0)
            {
                if(valorX % 2 == 0)
                {
                    contador = 0;
                    while (contador < 5)
                    {
                        valores[contador] = valorX;
                        valorX = valorX + 2;
                        contador++;
                    }
                    valorX = valores[0] + valores[1] + valores[2] + valores[3] + valores[4];
                    Console.WriteLine(valorX);

                }
                else
                {
                    valorX++;
                    contador = 0;
                    while (contador < 5)
                    {
                        valores[contador] = valorX;
                        valorX = valorX + 2;
                        contador++;
                    }
                    valorX = valores[0] + valores[1] + valores[2] + valores[3] + valores[4];
                    Console.WriteLine(valorX);

                }     
                valorX = int.Parse(Console.ReadLine());
            }
            

        }
    }
}
