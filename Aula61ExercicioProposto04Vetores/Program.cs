using System.Globalization;

int valorN;
double media;
valorN = int.Parse(Console.ReadLine());

string[] vet = new string[valorN];
vet = Console.ReadLine().Split(' ');

double[] vetorDeNumerosReais = new double[valorN];
//conversor para numeros com ponto flutuante
for(int i = 0; i < vetorDeNumerosReais.Length; i++)
{
    vetorDeNumerosReais[i] = double.Parse(vet[i], CultureInfo.InvariantCulture);
}

// soma e calculo da media aritmetica
media = 0;
for(int i = 0; i < vetorDeNumerosReais.Length; i++)
{
    media = media + vetorDeNumerosReais[i];
}
media = media / vetorDeNumerosReais.Length;

//resultado na tela
Console.WriteLine(media.ToString("F3"));
for(int i = 0; i< vetorDeNumerosReais.Length; i++)
{
    if (vetorDeNumerosReais[i] < media)
    {
        Console.WriteLine(vetorDeNumerosReais[i].ToString("F1"));
    }
}