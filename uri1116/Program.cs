using System;
using System.Globalization;

namespace uri1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int x = int.Parse(vet[0]);
                int y = int.Parse(vet[1]);

                if (y == 0)
                {
                    Console.WriteLine("divisao impossivel");
                }
                else
                {
                    double media = (double)x / y;
                    Console.WriteLine(media.ToString("F1", CultureInfo.InvariantCulture));
                }

            }
        }
    }
}
