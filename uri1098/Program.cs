using System;
using System.Globalization;

namespace uri1098
{
    class Program
    {
        static void Main(string[] args)
        {
            double I, J;
            I = 0;
            J = 1;

            do
            {
                for (int e = 0; e < 3; e++)
                {
                    Console.WriteLine("I=" + I + " J=" + J);
                    J++;
                }
                I += 0.2;
                J = J - 2.8;

            }
            while (I <= 2.0);
        }
    }
}
