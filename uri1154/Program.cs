using System;
using System.Globalization;

namespace uri1154
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade = int.Parse(Console.ReadLine());
            int cont = 0;
            int soma = 0;

            while (idade >= 0)
            {
                soma = soma + idade;
                cont++;
                idade = int.Parse(Console.ReadLine());
            }
            double total = (double)soma / cont;
            Console.WriteLine(total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
