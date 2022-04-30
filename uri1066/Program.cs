using System;

namespace uri1064
{
    class Program
    {
        static void Main(string[] args)
        {
            int par, impar, positivo, negativo, num;

            negativo = 0;
            positivo = 0;
            impar = 0;
            par = 0;

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            if (num > 0)
            {
                positivo++;
            }
            else if (num < 0)
            {
                negativo++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            if (num > 0)
            {
                positivo++;
            }
            else if (num < 0)
            {
                negativo++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            if (num > 0)
            {
                positivo++;
            }
            else if (num < 0)
            {
                negativo++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            if (num > 0)
            {
                positivo++;
            }
            else if (num < 0)
            {
                negativo++;
            }

            num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                par++;
            }
            else
            {
                impar++;
            }
            if (num > 0)
            {
                positivo++;
            }
            else if (num < 0)
            {
                negativo++;
            }
            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}
