using System;

namespace uri1179
{
    /*
    Leia um valor X. Coloque este valor na primeira posição de um vetor N[100]. Em cada posição subsequente de N (1 até 99),
    coloque a metade do valor armazenado na posição anterior, conforme o exemplo abaixo. Imprima o vetor N.

    Entrada
    A entrada contem um valor de dupla precisão com 4 casas decimais.

    Saída
    Para cada posição do vetor N, escreva "N[i] = Y", onde i é a posição do vetor e Y é o valor armazenado naquela posição. 
    Cada valor do vetor deve ser apresentado com 4 casas decimais.
    */

    class Program
    {
        static void Main(string[] args)
        {
            //Ler o vetor
            int[] vetPar = new int[5];
            int[] vetImpar = new int[5];

            int contPar = 0, contImpar = 0;
            int x;

            for (int i = 0; i < 15; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                {
                    vetPar[contPar] = x;
                    contPar++;
                }
                else
                {
                    vetImpar[contImpar] = x;
                    contImpar++;
                }
                if (contPar == 5)
                {
                    contPar = 0;
                    for (int j = 0; j < vetPar.Length; j++)
                    {
                        Console.WriteLine($"par[{j}] = {vetPar[j]}");
                    }
                }
                else if (contImpar == 5)
                {
                    contImpar = 0;
                    for (int j = 0; j < vetImpar.Length; j++)
                    {
                        Console.WriteLine($"impar[{j}] = {vetImpar[j]}");
                    }
                }
            }

            for (int k = 0; k < contImpar; k++)
            {
                Console.WriteLine($"impar[{k}] = {vetImpar[k]}");
            }
            for (int k = 0; k < contPar; k++)
            {
                Console.WriteLine($"par[{k}] = {vetPar[k]}");
            }
        }
    }
}


