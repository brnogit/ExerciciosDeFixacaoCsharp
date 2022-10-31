//6) Ler uma matriz quadrada de ordem N, contendo números reais. Em seguida, fazer as seguintes ações:
//a) calcular e imprimir a soma de todos os elementos positivos da matriz.
//b) fazer a leitura do índice de uma linha da matriz e, daí, imprimir todos os elementos desta linha.
//c) fazer a leitura do índice de uma coluna da matriz e, daí, imprimir todos os elementos desta coluna.
//d) imprimir os elementos da diagonal principal da matriz.
//e) alterar a matriz elevando ao quadrado todos os números negativos da mesma. Em seguida imprimir a matriz alterada.


using System.Globalization;

int numeroN, linha, coluna;
numeroN = int.Parse(Console.ReadLine());

double somaDosPositivos;
double[,] matriz = new double[numeroN, numeroN];

for(int i = 0; i < numeroN; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < numeroN; j++)
    {
        matriz[i, j] = double.Parse(vet[j], CultureInfo.InvariantCulture);
    }
}

//linha e coluna escolhida
linha = int.Parse(Console.ReadLine());
coluna = int.Parse(Console.ReadLine());







//soma dos positivos
somaDosPositivos = 0;
for(int i = 0; i < numeroN; i++)
{
    for(int j = 0; j < numeroN; j++)
    {
        if (matriz[i, j] > 0)
        {
            somaDosPositivos = somaDosPositivos + matriz[i, j];
        }
    }
}




Console.WriteLine("SOMA DOS POSITIVOS: "+ somaDosPositivos.ToString("F1", CultureInfo.InvariantCulture));

for (int i = linha; i == linha; i++)
{
    Console.Write("LINHA ESCOLHIDA: ");
    for (int j = 0; j < numeroN; j++)
    {
        Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
}
Console.WriteLine();
Console.Write("COLUNA ESCOLHIDA: ");
for (int i = 0; i < numeroN; i++)
{
    for (int j = coluna; j == coluna; j++)
    {
        Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
}

Console.WriteLine();
//diagonal principal
Console.Write("DIAGONAL PRINCIPAL: ");
for (int i = 0; i < numeroN; i++)
{
    Console.Write(matriz[i, i].ToString("F1", CultureInfo.InvariantCulture) + " ");
}

//matriz alterada
for (int i = 0; i < numeroN; i++)
{
    for (int j = 0; j < numeroN; j++)
    {
        if (matriz[i, j] < 0)
        {
            matriz[i, j] = matriz[i, j] * matriz[i, j];
        }
    }
}
Console.WriteLine();
Console.WriteLine("MATRIZ ALTERADA:");
for(int i = 0; i < numeroN; i++)
{
    for(int j = 0; j < numeroN; j++)
    {
        Console.Write(matriz[i, j].ToString("F1", CultureInfo.InvariantCulture) + " ");
    }
    Console.WriteLine();
}