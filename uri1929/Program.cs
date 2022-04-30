using System;

namespace uri1929
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double A = double.Parse(valores[0]);
            double B = double.Parse(valores[1]);
            double C = double.Parse(valores[2]);
            double D = double.Parse(valores[3]);

            if ((A + B > C) && (B + C > A) && (A + C > B))
            {
                Console.WriteLine("S");
            }
            else if ((B + C > D) && (C + D > B) && (B + D > C))
            {
                Console.WriteLine("S");
            }
            else if ((A + C > D) && (C + D > A) && (A + D > C))
            {
                Console.WriteLine("S");
            }
            else if ((A + B > D) && (B + D > A) && (A + D > B))
            {
                Console.WriteLine("S");
            }

            else
            {
                Console.WriteLine("N");
            }
        }
    }
}