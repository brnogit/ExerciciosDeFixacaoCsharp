using System;

namespace exercicioproposto1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN, valorX, qntdeDentro, qntdeFora;
            valorN = int.Parse(Console.ReadLine());

            qntdeFora = 0;
            qntdeDentro = 0;
            valorX = 0;
            for(int i = 0; i < valorN; i++)
            {
                valorX = int.Parse(Console.ReadLine());
                if(valorX >= 10 && valorX <= 20)
                {
                    qntdeDentro++;
                } else
                {
                    qntdeFora++;
                }
            }
            Console.WriteLine($"{qntdeDentro} in");
            Console.WriteLine($"{qntdeFora} out");
        }
    }
}
