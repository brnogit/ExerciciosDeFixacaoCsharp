//4) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar a soma dos elementos acima da diagonal principal.


int numeroN, soma;
numeroN = int.Parse(Console.ReadLine());

int[,] matriz = new int[numeroN, numeroN];

for (int i = 0; i < numeroN; i++)
{
    string[] vetorLeitor = Console.ReadLine().Split(' ');
    for(int j = 0; j < numeroN; j++)
    {
        matriz[i, j] = int.Parse(vetorLeitor[j]);
    }
}

soma = 0;
for (int i = 0; i < numeroN; i++)
{
    for(int j = 0; j< numeroN; j++)
    {
        if(i < j)
        {
            soma = soma + matriz[i, j];
        }
    }
}

Console.WriteLine(soma);