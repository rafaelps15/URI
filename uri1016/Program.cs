using System;

namespace uri1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double tempo;

            x = int.Parse(Console.ReadLine());

            tempo = (double)x * 2;

            Console.WriteLine(tempo + " minutos");
        }
    }
}
