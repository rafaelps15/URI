using System;

namespace uri1172
{
/*Faça um programa que leia um vetor X[10]. Substitua a seguir, todos os valores nulos e negativos
do vetor X por 1.Em seguida mostre o vetor X.

Entrada
A entrada contém 10 valores inteiros, podendo ser positivos ou negativos.

Saída
Para cada posição do vetor, escreva "X[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição.
*/
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[10];

            for (int i = 0; i < 10; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                if (vet[i] <= 0)
                {
                    vet[i] = 1;
                }
            }

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("X[" + i + "] = " + vet[i]);
            }
        }
    }
}
