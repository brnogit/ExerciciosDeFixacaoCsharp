int numeroA, numeroB, fila, ultimoDaFila;
numeroA = int.Parse(Console.ReadLine());
numeroB = int.Parse(Console.ReadLine());

int[,] matriz = new int[numeroA, numeroB];

for(int i = 0; i < numeroA; i++)
{
    string[] vet = Console.ReadLine().Split(' ');
    for(int j = 0; j < numeroB; j++)
    {
        matriz[i, j] = int.Parse(vet[j]);
    }
}

fila = int.Parse(Console.ReadLine());

fila = fila - 1;

ultimoDaFila = matriz[fila, numeroB - 1];

for(int j = numeroB - 1; j >0; j--)
{
    matriz[fila, j] = matriz[fila, j - 1];
}

matriz[fila, 0] = ultimoDaFila;

for(int i = 0; i < numeroA; i++)
{
    for(int j = 0; j < numeroB; j++)
    {
        Console.Write(matriz[i, j] + " ");
    }
    Console.WriteLine();
}
