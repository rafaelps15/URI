using System;
using System.Globalization;

namespace uir1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, mediaPonderada;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaPonderada = (a * 3.5 + b * 7.5) / 11;

            Console.WriteLine("MEDIA = " + mediaPonderada.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
