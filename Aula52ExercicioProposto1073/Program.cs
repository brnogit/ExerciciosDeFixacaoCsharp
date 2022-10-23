using System;

namespace exercicioproposto1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorN;
            valorN = int.Parse(Console.ReadLine());

                for (int i = 2; i <= valorN; i+=2)
                {
                    if(i % 2 == 0)
                    {
                    Console.WriteLine(i + "^" + 2 + " = " + Math.Pow(i, 2));
                    }             
                }
        }
    }
}
