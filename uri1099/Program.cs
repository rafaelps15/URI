using System;

namespace uri1099
{
    /*Leia um valor inteiro N que é a quantidade de casos de teste que vem 
     a seguir. Cada caso de teste consiste de dois inteiros X e Y. Você 
     deve apresentar a soma de todos os ímpares existentes entre X e Y.

     Entrada
     A primeira linha de entrada é um inteiro N que é a quantidade de casos 
     de teste que vem a seguir. Cada caso de teste consiste em uma linha
     contendo dois inteiros X e Y.

     Saída
     Imprima a soma de todos valores ímpares entre X e Y.*/
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (x > y)
                {
                    int invert;
                    invert = x;
                    x = y;
                    y = invert;
                }

                int impares = 0;
                for (int j = x + 1; j < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        impares += j;
                    }
                }
                Console.WriteLine(impares);
            }
        }
    }
}