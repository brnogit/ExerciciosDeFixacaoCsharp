using System.Globalization;

double numeroMaior, posicao;
int numero;
string[] vetorDeNumeros;
double[] vetorReal;

numero = int.Parse(Console.ReadLine());
vetorDeNumeros = new string[numero];
vetorReal = new double[numero];

vetorDeNumeros = Console.ReadLine().Split(' ');
for(int i = 0; i < numero; i++)
{
    vetorReal[i] = double.Parse(vetorDeNumeros[i], CultureInfo.InvariantCulture);
}

numeroMaior = 0;
posicao = 0;
for(int i = 0; i < numero; i++)
{
    if (vetorReal[i] > numeroMaior)
    {
        numeroMaior = vetorReal[i];
        posicao = i;
    }
}


Console.WriteLine(numeroMaior.ToString("F1", CultureInfo.InvariantCulture));
Console.WriteLine(posicao);

