using System;

namespace uri1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, horas, min, seg, resto;

            n = int.Parse(Console.ReadLine());

            horas = n / 3600;
            resto = n % 3600;

            min = resto / 60;
            seg = resto % 60;

            Console.WriteLine(horas + ":" + min + ":" + seg);
        }
    }
}
