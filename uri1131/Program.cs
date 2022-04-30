using System;

namespace uri1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int vitoriasInter = 0;
            int vitoriasGremio = 0;
            int empates = 0;
            int novoGrenal = 1;

            while (novoGrenal == 1)
            {
                string[] vet = Console.ReadLine().Split(' ');
                int golsInter = int.Parse(vet[0]);
                int golsGremio = int.Parse(vet[1]);

                if (golsInter > golsGremio)
                {
                    vitoriasInter++;
                }
                else if (golsGremio > golsInter)
                {
                    vitoriasGremio++;
                }
                else
                {
                    empates++;
                }

                Console.WriteLine("Novo grenal (1-sim 2-nao)");
                novoGrenal = int.Parse(Console.ReadLine());
            }

            int totalGrenais = vitoriasInter + vitoriasGremio + empates;

            Console.WriteLine(totalGrenais + " grenais");
            Console.WriteLine("Inter:" + vitoriasInter);
            Console.WriteLine("Gremio:" + vitoriasGremio);
            Console.WriteLine("Empates:" + empates);

            if (vitoriasGremio > vitoriasInter)
            {
                Console.WriteLine("Gremio venceu mais");
            }
            else if (vitoriasInter > vitoriasGremio)
            {
                Console.WriteLine("Inter venceu mais ");
            }
        }
    }
}
