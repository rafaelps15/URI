using System;

namespace uri1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, anos, meses, dias, resto;

            n = int.Parse(Console.ReadLine());

            anos = n / 365;
            Console.WriteLine(anos + " ano(s)");

            resto = n % 365;
            meses = resto / 30;
            Console.WriteLine(meses + " mes(s)");

            dias = resto % 30;
            Console.WriteLine(dias + " dia(s)");

        }
    }
}
