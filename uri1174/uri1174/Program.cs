using System;
using System.Globalization;

namespace Iniciante;
  /*
  Faça um programa que leia um vetor A[100]. No final, mostre todas as posições do vetor que armazenam 
  um valor menor ou igual a 10 e ovalor armazenado em cada uma das posições.

  Entrada
  A entrada contém 100 valores, podendo ser inteiros, reais, positivos ou negativos.

  Saída
  Para cada valor do vetor menor ou igual a 10, escreva "A[i] = x", onde i é a posição dovetor e x é o
  valor armazenado na posição, com uma casa após o ponto decimal.
  */
class uri1174
{
    static void Main(string[] args)
    {
        double[] vet = new double[100];
        for (int i = 0; i < vet.Length; i++)
        {
            vet[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        }
        for (int i = 0; i < vet.Length; i++)
        {
            if (vet[i] <= 10)
            {
                Console.WriteLine("A[" + i + "] = " + vet[i].ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}
