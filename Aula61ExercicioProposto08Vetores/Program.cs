using System.Globalization;

int valorN, numeroDeHomens, quantidade;
double mediaMulheres, menorAltura, maiorAltura;
valorN = int.Parse(Console.ReadLine());

double[] altura = new double[valorN];
char[] sexo = new char[valorN];
//leitura dos valores
for(int i = 0; i < valorN; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    altura[i] = double.Parse(vet[0], CultureInfo.InvariantCulture);
    sexo[i] = char.Parse(vet[1]);
}

// media de altura das mulheres
quantidade = 0;
mediaMulheres = 0;
for(int i = 0; i < valorN; i++)
{
    if (sexo[i] == 'F')
    {
        mediaMulheres = mediaMulheres + altura[i];
        quantidade++;
    }
}
mediaMulheres = mediaMulheres / quantidade;

// menor altura do grupo
menorAltura = altura[0];
for(int i = 0; i < valorN; i++)
{
    if (altura[i] < menorAltura)
    {
        menorAltura = altura[i];
    }
}

// maior altura do grupo
maiorAltura = altura[0];
for(int i = 0; i < valorN; i++)
{
    if (altura[i] > maiorAltura)
    {
        maiorAltura = altura[i];
    }
}


// numero de homens
numeroDeHomens = 0;
for(int i = 0; i < valorN; i++)
{
    if (sexo[i] == 'M')
    {
        numeroDeHomens++;
    }
}

Console.WriteLine($"Menor altura = {menorAltura:F2}");
Console.WriteLine($"Maior altura = {maiorAltura:F2}");
Console.WriteLine($"Media das alturas das mulheres = {mediaMulheres:f2}");
Console.WriteLine($"Numero de homens = {numeroDeHomens}");