using System;

namespace uri1149
{
    class Program
    {
        /*Faça um algoritmo para ler um valor A e um valor N. Imprimir 
          a soma de A + ipara cada i com os valores (0 <= i <= N-1).
          Enquanto N for negativo ou ZERO, um novo N(apenas N) deve ser lido.

          Entrada**
          A entrada contém somente valores inteiros, podendo ser positivos 
          ou negativos.Todos os valores estão na mesma linha.

          Saída**
          A saída contém apenas um valor inteiro.*/
        static void Main(string[] args)
        {
            string[] vet = Console.ReadLine().Split(' ');

            int A = int.Parse(vet[0]);

            int i = 1;
            int N = int.Parse(vet[i]);
            while (N <= 0)
            {
                i++;
                N = int.Parse(vet[i]);
            }

            int soma = 0;
            for (i = 0; i < N; i++)
            {
                soma = soma + A + i;
            }
            Console.WriteLine(soma);
        }
    }
}
