using System;
using System.Globalization;

namespace uri1038
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            int cod = int.Parse(valores[0]);
            int quant = int.Parse(valores[1]);

            double soma;
            if (cod == 1)
            {
                soma = quant * 4.0;
            }
            else if (cod == 2)
            {
                soma = quant * 4.5;
            }
            else if (cod == 3)
            {
                soma = quant * 5.0;
            }
            else if (cod == 4)
            {
                soma = quant * 2.0;
            }
            else
            {
                soma = quant * 1.5;
            }

            Console.WriteLine("Total: R$ " + soma.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

