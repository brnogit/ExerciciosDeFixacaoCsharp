using System.Globalization;

int valorN, lucro10, lucroEntre10e20, lucroAcimaDe20;
double porcentagemLucro, valorTotalDeCompra, valorTotalDeVenda, lucroTotal; ;
valorN = int.Parse(Console.ReadLine());

string[] nome = new string[valorN];
double[] precoDeCompra = new double[valorN];
double[] precoDeVenda = new double[valorN];

for(int i = 0; i < valorN; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    nome[i] = vet[0];
    precoDeCompra[i] = double.Parse(vet[1], CultureInfo.InvariantCulture);
    precoDeVenda[i] = double.Parse(vet[2], CultureInfo.InvariantCulture);
}

porcentagemLucro = 0;

lucro10 = 0;
lucroEntre10e20 = 0;
lucroAcimaDe20 = 0;
for(int i = 0; i < valorN; i++)
{
    porcentagemLucro = ((precoDeVenda[i] - precoDeCompra[i]) / precoDeCompra[i]) * 100.00;

    if (porcentagemLucro < 10)
    {
        lucro10++;
    }
    else if (porcentagemLucro >= 10  && porcentagemLucro <= 20) 
    {
        lucroEntre10e20++;
    }
    else if (porcentagemLucro > 20)
    {
        lucroAcimaDe20++;
    }
}

valorTotalDeCompra = 0;
valorTotalDeVenda = 0;

for(int i = 0; i < valorN; i++)
{
    valorTotalDeCompra = valorTotalDeCompra + precoDeCompra[i];
    valorTotalDeVenda = valorTotalDeVenda + precoDeVenda[i];
}

lucroTotal = valorTotalDeVenda - valorTotalDeCompra;

Console.WriteLine($"Lucro abaixo de 10%: {lucro10}");
Console.WriteLine($"Lucro entre 10% e 20%: {lucroEntre10e20}");
Console.WriteLine($"Lucro acima de 20%: {lucroAcimaDe20}");
Console.WriteLine($"Valor total de compra: {valorTotalDeCompra:f2}");
Console.WriteLine($"Valor total de venda: {valorTotalDeVenda:f2}");
Console.WriteLine($"Lucro total: {lucroTotal:f2}");