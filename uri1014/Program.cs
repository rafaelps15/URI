using System;
using System.Globalization;

namespace uri1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            double y, media;

            x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (double)x / y;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");
        }
    }
}