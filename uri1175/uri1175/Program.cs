using System;

namespace Iniciante;
  /*
  Faça um programa que leia um vetor N[20]. Troque a seguir, o primeiro elemento com o último, 
  o segundo elemento com o penúltimo, etc., até trocar o 10º com o 11º. Mostre o vetor modificado.

  Entrada
  A entrada contém 20 valores inteiros, positivos ou negativos.

  Saída
  Para cada posição do vetor N, escreva "N[i] = Y", onde i é a posição do vetor e Y é o valor armazenado 
  naquela posição.
  */

class uri1175
{
    static void Main(string[] args)
    {
        //Leitura dos números do vetor
        int[] vet = new int[20];
        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = int.Parse(Console.ReadLine());
        }

        //Lógica para trocar de posição 
        int aux;
        for (int i = 0; i < (vet.Length / 2); i++)
        {
            aux = vet[i];
            vet[i] = vet[vet.Length - 1 - i];
            vet[vet.Length - 1 - i] = aux;
        }

        //Impressão do vetor
        for (int i = 0; i < vet.Length; i++)
        {
            Console.WriteLine("N[" + i + "] = " + vet[i]);
        }
    }
}


