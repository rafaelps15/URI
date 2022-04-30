using System;

namespace uri1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            int cont = 0;
            if (n1 % 2 == 0)
            {
                cont++;
            }
            if (n2 % 2 == 0)
            {
                cont++;
            }
            if (n3 % 2 == 0)
            {
                cont++;
            }
            if (n4 % 2 == 0)
            {
                cont++;
            }
            if (n5 % 2 == 0)
            {
                cont++;
            }
            Console.WriteLine(cont + " valores pares");
        }
    }
}
