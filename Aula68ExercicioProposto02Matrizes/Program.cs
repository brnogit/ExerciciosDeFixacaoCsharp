//Ler um número N e depois uma matriz quadrada NxN com números inteiros. Depois, mostrar na tela a soma dos
//elementos de cada linha da matriz.


int numeroN, soma;
numeroN = int.Parse(Console.ReadLine());

int[,] matriz = new int[numeroN, numeroN];

for(int linha = 0; linha < numeroN; linha++)
{
    string[] vetorLeitor = Console.ReadLine().Split(' ');
    for(int coluna = 0; coluna < numeroN; coluna++)
    {
        matriz[linha, coluna] = int.Parse(vetorLeitor[coluna]);
    }
}

for(int i = 0; i < numeroN; i++)
{
    soma = 0;
    for(int j = 0; j < numeroN; j++)
    {
        soma = soma + matriz[i, j];
        
    }
    Console.WriteLine(soma);
}