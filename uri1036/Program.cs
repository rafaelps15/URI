using System;
using System.Globalization;

namespace uri1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, x1, x2;

            string[] valores = Console.ReadLine().Split(' ');
            A = double.Parse(valores[0], CultureInfo.InvariantCulture);
            B = double.Parse(valores[1], CultureInfo.InvariantCulture);
            C = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if ((Math.Pow(B, 2) - (4 * A * C) < 0) || (A == 0))
            {
                Console.WriteLine("Impossivel calcular");
            }
            else
            {
                x1 = (-B + Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);
                x2 = (-B - Math.Sqrt(Math.Pow(B, 2) - (4 * A * C))) / (2 * A);

                Console.WriteLine("R1 = " + x1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("R2 = " + x2.ToString("F5", CultureInfo.InvariantCulture));
            }
        }
    }
}
