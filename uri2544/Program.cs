using System;
using System.IO;

namespace uri2544
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var entrada = Console.ReadLine();

                if (!int.TryParse(entrada, out _))
                    break;

                Console.WriteLine(Math.Log(int.Parse(entrada), 2));
            }
        }
    }
}
