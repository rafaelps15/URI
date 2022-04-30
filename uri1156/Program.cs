using System;

namespace uri1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double S = 1.00;
            double divisor = 2.00;
            double dividendo = 3.00;
            for (int i = 1; i <= 18; i++)
            {
                S = S + dividendo / divisor;
                dividendo += 2.00;
                divisor *= 2.00;
            }
            Console.WriteLine(S.ToString("F2"));
        }
    }
}
