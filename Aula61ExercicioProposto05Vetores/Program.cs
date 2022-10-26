using System.Globalization;

int valorN, qntdPar;
double media;
valorN = int.Parse(Console.ReadLine());

string[] vet = new string[valorN];
vet = Console.ReadLine().Split(' ');

double[] numeros = new double[valorN];
for( int i = 0; i < valorN; i++)
{
    numeros[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

media = 0;
qntdPar = 0;
for(int i = 0; i < valorN; i++)
{
    if (numeros[i] % 2 == 0)
    {
        media = media + numeros[i];
        qntdPar++;
    }
}

media = media / qntdPar;

Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));