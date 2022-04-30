using System;

namespace uri1158
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] valores = Console.ReadLine().Split(' ');
                int x = int.Parse(valores[0]);
                int y = int.Parse(valores[1]);

                int impares = 0;
                int soma = 0;
                for (int j = x; impares < y; j++)
                {
                    if (j % 2 != 0)
                    {
                        soma = soma + j;
                        impares++;
                    }
                }
                Console.WriteLine(soma);
            }
        }
    }
}