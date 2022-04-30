using System;

namespace uri1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, Diferencaproduto;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            d = int.Parse(Console.ReadLine());

            Diferencaproduto = (a * b) - (c * d);

            Console.WriteLine("DIFERENCA = " + Diferencaproduto);

        }
    }
}
