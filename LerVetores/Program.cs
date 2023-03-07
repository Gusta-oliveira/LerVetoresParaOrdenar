int[] vetorA = new int[5];
int[] vetorB = new int[5];
int[] vetorC = new int[10];

LerVetor(vetorA, "Vetor A");
LerVetor(vetorB, "Vetor B");

int[] Concatenar_vetor(int[] auxa, int[]auxb)
{
    int[] vetor = new int[10];
    for(int i = 0; i < auxa.Length; i++)
        vetor[i] = auxa[i];
    for(int i = 0; i < auxb.Length; i++)
        vetor[5+i] = auxb[i];
    return vetor;
}
vetorC = Concatenar_vetor(vetorA, vetorB);
OrdenarVetor(vetorC);
ImprimirVetor(vetorC);




void LerVetor(int[] aux, string texto)
{
    Console.WriteLine($"Informe o valor do vetor {texto}");
    for (int i = 0; i < aux.Length; i++)
    {
        Console.Write($"Vetor {i}: ");
        aux[i] = int.Parse(Console.ReadLine());
    }
}
void ImprimirVetor(int[] aux)
{
    for(int i = 0; i < aux.Length; i++)
    {
        Console.Write($"\nValor {i} " + aux[i]); 
    }
}
void OrdenarVetor(int[] vetor)
{
    int aux;
    for (int i = 0; i < (vetor.Length - 1); i++)
    {
        for (int j = i+1; j < vetor.Length; j++)
        {
            if (vetor[i] > vetor[j])
            {
                aux = vetor[i]; 
                vetor[i] = vetor[j];
                vetor[j] = aux;
            }
        }
    }
}