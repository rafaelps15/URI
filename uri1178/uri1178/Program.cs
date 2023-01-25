﻿using System;
using System.Globalization;

namespace Iniciante;
  /*
  Leia um valor X. Coloque este valor na primeira posição de um vetor N[100]. Em cada posição subsequente de N (1 até 99),
  coloque a metade do valor armazenado na posição anterior, conforme o exemplo abaixo. Imprima o vetor N.

  Entrada
 
  A entrada contem um valor de dupla precisão com 4 casas decimais.

  Saída
  Para cada posição do vetor N, escreva "N[i] = Y", onde i é a posição do vetor e Y é o valor armazenado naquela posição. 
  Cada valor do vetor deve ser apresentado com 4 casas decimais.
  */

class uri1178
{
    static void Main(string[] args)
    {
        double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        //Ler o vetor
        double[] vet = new double[100];

        //Lógica cálculo do vetor
        vet[0] = valor;
        for (int i = 1; i < 100; i++)
        {
            vet[i] = vet[i - 1] / 2.0;
        }

        //Imprimir o vetor
        for (int i = 0; i < 100; i++)
        {
            Console.WriteLine($"N [{i}] = {vet[i].ToString("F4", CultureInfo.InvariantCulture)}");
        }
    }
}

