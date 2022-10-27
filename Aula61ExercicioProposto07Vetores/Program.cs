using System.Globalization;

int valorN;
valorN = int.Parse(Console.ReadLine());

string[] nomes = new string[valorN];
double[] nota1 = new double[valorN];
double[] nota2 = new double[valorN];

for(int i = 0; i < valorN; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    nomes[i] = vet[0];
    nota1[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
    nota2[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
}


Console.WriteLine("Alunos aprovados:");
for(int i = 0; i < nomes.Length; i++)
{
    if (((nota1[i] + nota2[i]) / 2.0) >= 6.0)
    {
        Console.WriteLine(nomes[i]);
    }
}
