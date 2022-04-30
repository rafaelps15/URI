using System;

namespace uri2059
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int p = int.Parse(valores[0]);
            int j1 = int.Parse(valores[1]);
            int j2 = int.Parse(valores[2]);
            int r = int.Parse(valores[3]);
            int a = int.Parse(valores[4]);

            if (r == 1 && a == 0)
            {
                Console.WriteLine("Jogador 1 ganha!");
            }
            else if (r == 0 && a == 1)
            {
                Console.WriteLine("Jogador 1 ganha!");
            }
            else if (r == 1 && a == 1)
            {
                Console.WriteLine("Jogador 2 ganha!");
            }
            else if (p == 0 && (j1 + j2) % 2 != 0)
            {
                Console.WriteLine("Jogador 1 ganha!");
            }
            else if (p == 1 && (j1 + j2) % 2 == 0)
            {
                Console.WriteLine("Jogador 1 ganha!");
            }
            else
            {
                Console.WriteLine("Jogador 2 ganha!");
            }
        }
    }
}
