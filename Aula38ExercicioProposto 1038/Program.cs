using System;
using System.Globalization;

namespace exercicioproposto1038
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, qntdItem;
            double total;

            string[] valores = Console.ReadLine().Split(' ');
            codigo = int.Parse(valores[0], CultureInfo.InvariantCulture);
            qntdItem = int.Parse(valores[1], CultureInfo.InvariantCulture);

            switch (codigo) {
                case 1:
                    total = 4.00 * qntdItem;
                    Console.WriteLine($"Total: R$ {total:F2}", CultureInfo.InvariantCulture);
                    break;
                case 2:
                    total = 4.50 * qntdItem;
                    Console.WriteLine($"Total: R$ {total:F2}", CultureInfo.InvariantCulture);
                    break;
                case 3:
                    total = 5.00 * qntdItem;
                    Console.WriteLine($"Total: R$ {total:F2}", CultureInfo.InvariantCulture);
                    break;
                case 4:
                    total = 2.00 * qntdItem;
                    Console.WriteLine($"Total: R$ {total:F2}", CultureInfo.InvariantCulture);
                    break;
                case 5:
                    total = 1.50 * qntdItem;
                    Console.WriteLine($"Total: R$ {total:F2}", CultureInfo.InvariantCulture);
                    break;

            
            }

            
        }
    }
}