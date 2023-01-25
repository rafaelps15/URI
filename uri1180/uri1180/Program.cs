using System;

namespace uri1180
{
    /*
      Faça um programa que leia um valor N. Este N será o tamanho de um vetor X[N]. A seguir, leia cada um dos valores de X, 
      encontre o menor elemento deste vetor e a sua posição dentro do vetor, mostrando esta informação.

      Entrada
      A primeira linha de entrada contem um único inteiro N (1 < N < 1000), indicando o número de elementos que deverão ser
      lidos em seguida para o vetor X[N] de inteiros. A segunda linha contém cada um dos N valores, separados por um espaço. 
      Vale lembrar que nenhuma entrada haverá números repetidos.

      Saída
      A primeira linha apresenta a mensagem “Menor valor:” seguida de um espaço e do menor valor lido na entrada. A segunda 
      linha apresenta a mensagem “Posicao:” seguido de um espaço e da posição do vetor na qual se encontra o menor valor lido, 
      lembrando que o vetor inicia na posição zero.
    */

    class program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] vet = new int[n];

            string[] valores = Console.ReadLine().Split(' ');

            //leitura dos vetores
            for (int i = 1; i < vet.Length; i++)
            {
                vet[i] = int.Parse(valores[i]);
            }

            //logica
            int menor = vet[0];
            int posicaoMenor = 0;

            //imprimir o vetor
            for (int i = 1; i < vet.Length; i++)
            {
                if (vet[i] < menor)
                {
                    menor = vet[i];
                    posicaoMenor = i;
                }
            }
            Console.WriteLine("Menor valor: " + menor);
            Console.WriteLine("Posicao: " + posicaoMenor);
        }
    }
}