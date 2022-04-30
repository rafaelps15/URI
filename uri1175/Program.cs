using System;

namespace uri1175
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vet = new int[20];

            for (int i = 0; i < 20; i++)
            {
                vet[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++)
            {
                int temp = vet[i];
                vet[i] = vet[19 - i];
                vet[19 - i] = temp;
            }
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("N [" + i + "] = " + vet[i]);
            }
        }
    }
}
