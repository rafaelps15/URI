using System;

namespace uri2031
{
    class Program
    {
        static void Main(string[] args)
        {
            string jogador1, jogador2;

            int N = int.Parse(Console.ReadLine());
            for (int i = 0; i < N; i++)
            {
                jogador1 = Console.ReadLine();
                jogador2 = Console.ReadLine();

                if (jogador1 == "ataque" && jogador2 == "ataque")
                {
                    Console.WriteLine("Aniquilacao mutua");
                }
                else if (jogador1 == "papel" && jogador2 == "papel")
                {
                    Console.WriteLine("Ambos venceram");
                }
                else if (jogador1 == "ataque")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (jogador2 == "ataque")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else if (jogador2 == "papel")
                {
                    Console.WriteLine("Jogador 1 venceu");
                }
                else if (jogador1 == "papel")
                {
                    Console.WriteLine("Jogador 2 venceu");
                }
                else
                {
                    Console.WriteLine("Sem ganhador");
                }
            }
        }
    }
}

