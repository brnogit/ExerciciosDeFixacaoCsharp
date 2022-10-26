int valorN, maiorIdade, pessoa;
valorN = int.Parse(Console.ReadLine());

string[] pessoas = new string[valorN];
string[] idades = new string[valorN];

// recebendo as informacoes
for (int i = 0; i < valorN; i++)
{
    string[] temporaria = Console.ReadLine().Split(' ');
    pessoas[i] = temporaria[0];
    idades[i] = temporaria[1];
}


//convertendo para int
int[] idadesNumeros = new int[valorN];
for( int i = 0; i < valorN; i++)
{
    idadesNumeros[i] = int.Parse(idades[i]);
}


//verificando maior idade
maiorIdade = 0;
pessoa = 0;
for(int i = 0; i < valorN; i++)
{
    if (idadesNumeros[i] > maiorIdade) 
    { 
        maiorIdade = idadesNumeros[i];
        pessoa = i;
    }
}

Console.WriteLine($"Pessoa mais velha: {pessoas[pessoa]}");
