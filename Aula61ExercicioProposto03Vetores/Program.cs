
int valorN;
valorN = int.Parse(Console.ReadLine());

string[] valoresA = new string[valorN];
valoresA = Console.ReadLine().Split(' ');

string[] valoresB = new string[valorN];
valoresB = Console.ReadLine().Split(' ');

int[] intA = new int[valorN];
int[] intB = new int[valorN];
int[] soma = new int[valorN];

for(int i = 0; i < valoresA.Length; i++)
{
    intA[i] = int.Parse(valoresA[i]);
}

for(int i = 0; i < valoresB.Length; i++)
{
    intB[i] = int.Parse(valoresB[i]);
}

for(int i = 0; i < intA.Length; i++)
{
    soma[i] = intA[i] + intB[i];
}

for(int i = 0; i < soma.Length; i++)
{
    Console.Write(soma[i] + " ");
}