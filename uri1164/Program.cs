using System;

namespace uri1164
{   /*Na matemática, um número perfeito é um número inteiro para o qual a soma de 
     todos os seus divisores positivos próprios (excluindo ele mesmo) é igual 
     ao próprio número. Por exemplo o número 6 é perfeito, pois 1+2+3 é igual a 6.
     Sua tarefa é escrever um programa que imprima se um determinado número é 
     perfeito ou não.*/


    class Program
    {
        static void Main(string[] args)
        {
            {
                int n = int.Parse(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    int soma = 0;
                    int perfeito = int.Parse(Console.ReadLine());
                    for (int j = 1; j < perfeito; j++)
                    {
                        if (perfeito % j == 0)
                        {
                            soma += j;
                        }
                    }
                    if (soma == perfeito)
                    {
                        Console.WriteLine(perfeito + " eh perfeito");
                    }
                    else
                    {
                        Console.WriteLine(perfeito + " nao eh perfeito");
                    }
                }
            }
        }
    }
}