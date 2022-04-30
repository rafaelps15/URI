using System;
using System.Globalization;
namespace uri1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int numFunc, hrTrab;
            double valorHr, salarioFunc;

            numFunc = int.Parse(Console.ReadLine());
            hrTrab = int.Parse(Console.ReadLine());
            valorHr = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioFunc = hrTrab * valorHr;

            Console.WriteLine("NUMBER = " + numFunc);
            Console.WriteLine("SALARY = U$ " + salarioFunc.ToString("F2"), CultureInfo.InvariantCulture);             
        }
    }
}
