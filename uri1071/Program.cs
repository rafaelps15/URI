using System;

namespace uri1071
{
    /*Leia 2 valores inteiros X e Y. A seguir, calcule e mostre a soma dos números impares entre eles.

    Entrada
    O arquivo de entrada contém dois valores inteiros.

    Saída
    O programa deve imprimir um valor inteiro. Este valor é a soma dos valores ímpares que estão entre
    os valores fornecidos na entrada que deverá caber em um inteiro.*/

    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int impares = 0;
            if (x < y)
            {
                for (int i = x + 1; i < y; i++)
                {
                    if (i % 2 != 0)
                    {
                        impares += i;
                    }
                }
            }
            else
            {
                for (int i = y + 1; i < x; i++)
                {
                    if (i % 2 != 0)
                    {
                        impares += i;
                    }
                }
            }
            Console.WriteLine(impares);
        }
    }
}


