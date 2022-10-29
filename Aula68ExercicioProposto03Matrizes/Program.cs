//3) Ler um inteiro N e uma matriz quadrada de ordem N. Mostrar qual o maior elemento de cada linha. Suponha não haver
//empates.
int numeroN, maiorElemento;
numeroN = int.Parse(Console.ReadLine());

int[,] matriz = new int[numeroN, numeroN];


//leitura de dados
for(int i = 0; i < numeroN; i++)
{
    string[] vetorLeitor = Console.ReadLine().Split(' ');
    for(int j = 0; j < numeroN; j++)
    {
        matriz[i, j] = int.Parse(vetorLeitor[j]);
    }
}

for(int i = 0; i < numeroN; i++)
{
    maiorElemento = 0;
    for(int j = 0; j < numeroN; j++)
    {
        if (matriz[i, j] > maiorElemento)
        {
            maiorElemento = matriz[i, j];
        }
        
    }
    Console.WriteLine(maiorElemento);
}