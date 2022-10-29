
#region Leitura dos dados
int linhaN, colunaM;
string[] vetorLinhaColuna = Console.ReadLine().Split(' ');
linhaN = int.Parse(vetorLinhaColuna[0]);
colunaM = int.Parse(vetorLinhaColuna[1]);

int[,] matriz = new int[linhaN, colunaM];

for(int i = 0; i < linhaN; i++)
{
    string[] vetorLeitor = Console.ReadLine().Split(' ');
    for(int j = 0; j < colunaM; j++)
    {
        matriz[i, j] = int.Parse(vetorLeitor[j]);
    }
}
#endregion

#region Valores Negativos
Console.WriteLine("VALORES NEGATIVOS:");
for (int i = 0; i < linhaN; i++)
{
    for(int j = 0; j< colunaM; j++)
    {
        if (matriz[i, j] < 0)
        {
            Console.WriteLine(matriz[i, j]);
        }
    }
}
#endregion