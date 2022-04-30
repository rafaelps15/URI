using System;
using System.Globalization;

namespace uri1013
{
    class Program
    {
        static void Main(string[] args)
        {
            double x, y, z;

            string[] valores = Console.ReadLine().Split(' ');

            x = double.Parse(valores[0], CultureInfo.InvariantCulture);
            y = double.Parse(valores[1], CultureInfo.InvariantCulture);
            z = double.Parse(valores[2], CultureInfo.InvariantCulture);

            if (x > y && x > z)
            {
                Console.WriteLine(x + " eh o maior");
            }
            else if (y > z)
            {
                Console.WriteLine(y + " eh o maior");
            }
            else
            {
                Console.WriteLine(z + " eh o maior");
            }

        }
    }
}

// Utilizando a fórmula do exercício
//using System;

//namespace uri1013
//{
//  class Program
// {
//   static void Main(string[] args)
// {

//   int x, y, z, maiorXY, maior;

// string[] valores = Console.ReadLine().Split(' ');
// x = int.Parse(valores[0]);
// y = int.Parse(valores[1]);
// z = int.Parse(valores[2]);

//maiorXY = (x + y + Math.Abs(x - y)) / 2;

// maior = (maiorXY + z + Math.Abs(maiorXY - z)) / 2;

//Console.WriteLine(maior + " eh o maior");
//}
// }
//}