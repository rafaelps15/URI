using System;

namespace uri1176
{
    /*
    Faça um programa que leia um valor e apresente o número de Fibonacci correspondente a este valor lido.
    Lembre que os 2 primeiros elementos da série de Fibonacci são 0 e 1 e cada próximo termo é a soma dos 2 anteriores a ele. 
    Todos os valores de Fibonacci calculados neste problema devem caber em um inteiro de 64 bits sem sinal.

    Entrada
    A primeira linha da entrada contém um inteiro T, indicando o número de casos de teste. Cada caso de teste contém um único
    inteiro N (0 ≤ N ≤ 60), correspondente ao N-esimo termo da série de Fibonacci.

    Saída
    Para cada caso de teste da entrada, imprima a mensagem "Fib(N) = X", onde X é o N-ésimo termo da série de Fibonacci.
    */

    class program
    {
        static void Main(string[] args)
        {
            //Quantidade de repretições
            int N = int.Parse(Console.ReadLine());

            long[] fib = new long[61];

            for (int i = 0; i < 61; i++)
            {
                fib[i] = int.Parse(Console.ReadLine());
            }

            //Iniciando o vetor fibonnaci com 2 posições e 2 valores atribuídos
            fib[0] = 0;
            fib[1] = 1;

            //Lógica de fibonnaci utilizandos os valores descritos no exercício
            for (int i = 2; i < 61; i++)
            {
                fib[i] = fib[i - 2] + fib[i - 1];
            }

            for (int j = 0; j < 61; j++)
            {
                int f = int.Parse(Console.ReadLine());
                Console.WriteLine($"Fib ({f}) = {fib[f]}");
            }
        }
    }
}
