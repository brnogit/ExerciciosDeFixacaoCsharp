
int linhasM, colunasN;

string[] vetorLeitor = Console.ReadLine().Split(' ');
linhasM = int.Parse(vetorLeitor[0]);
colunasN = int.Parse(vetorLeitor[1]);

int[,] matrizA = new int[linhasM, colunasN];
int[,] matrizB = new int[linhasM, colunasN];
int[,] matrizC = new int[linhasM, colunasN];

for(int i = 0; i < linhasM; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < colunasN; j++)
    {
        matrizA[i, j] = int.Parse(vet[j]);
    }
}

for(int i = 0; i < linhasM; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < colunasN; j++)
    {
        matrizB[i, j] = int.Parse(vet[j]);
    }
}

for(int i = 0; i < linhasM; i++)
{
    for(int j = 0; j < colunasN; j++)
    {
        matrizC[i, j] = matrizA[i, j] + matrizB[i, j];
    }
}

for(int i = 0; i < linhasM; i ++)
{
    Console.WriteLine();
    for(int j = 0; j < colunasN; j++)
    {
        Console.Write(matrizC[i, j] + " ");
    }
}