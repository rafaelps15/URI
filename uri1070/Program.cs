using System;

namespace uri1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            int quantidadeImpares = 0;

            for (int i = x; quantidadeImpares < 6; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    quantidadeImpares++;
                }
            }
        }
    }
}
