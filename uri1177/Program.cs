using System;

namespace uri1177
{
    class Program
    {
        /*Faça um programa que leia um valor T e preencha um vetor N[1000] com a sequência de
        valores de 0 até T-1 repetidas vezes, conforme exemplo abaixo. Imprima o vetor N.
        Entrada
        A entrada contém um valor inteiro T(2 ≤ T ≤ 50)
        Saída
        Para cada posição do vetor, escreva "N[i] = x", onde i é a posição do vetor e x é o valor armazenado naquela posição.*/

        static void Main(string[] args)
        {
            int T = int.Parse(Console.ReadLine());
            int[] vet = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                vet[i] = i % T;
            }

            for (int j = 0; j < 1000; j++)
            {
                Console.WriteLine("N[" + j + "] = " + vet[j]);
            }
        }
    }
}
