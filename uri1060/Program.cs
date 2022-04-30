using System;
using System.Globalization;

namespace uri1060
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double n6 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            int cont = 0;
            if (n1 > 0.0)
            {
                cont++;
            }
            if (n2 > 0.0)
            {
                cont++;
            }
            if (n3 > 0.0)
            {
                cont++;
            }
            if (n4 > 0.0)
            {
                cont++;
            }
            if (n5 > 0.0)
            {
                cont++;
            }
            if (n6 > 0.0)
            {
                cont++;
            }
            Console.WriteLine(cont + " valores positivos");
        }
    }
}
