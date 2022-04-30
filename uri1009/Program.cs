using System;
using System.Globalization;

namespace uri1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double salario, totalVendas, comissao;

            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            totalVendas = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            comissao = salario + (0.15 * totalVendas);

            Console.WriteLine("TOTAL = R$ " + comissao.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
