
int numeros, qntdPar;
numeros = int.Parse(Console.ReadLine());

int[] vet = new int[numeros];
string[] numeroVetor = new string[numeros];
numeroVetor = Console.ReadLine().Split(' ');


// Conveter em vetor de numeros inteiros
for(int i = 0; i < numeros; i++)
{
    vet[i] = int.Parse(numeroVetor[i]);
}


// verifica quantos numeros pares existem e armazena em um novo vetor
int[] pares = new int[numeros];
qntdPar = 0;
for(int i = 0; i < numeros; i++)
{
    if (vet[i] % 2 == 0 && vet[i] != 0)
    {  
        pares[qntdPar] = vet[i];
        qntdPar++;
    }
    
}


// imprime os numeros
for (int i = 0; i < qntdPar; i++)
{
    Console.Write(pares[i] + " ");
}
Console.WriteLine();
Console.WriteLine(qntdPar);