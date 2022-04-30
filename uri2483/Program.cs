using System;

namespace uri2483
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string letra = "a";

            for (int i = 1; i < n; i++)
            {
                letra += "a";
            }
            Console.WriteLine("Feliz nat" + letra + "l!");
        }
    }
}
