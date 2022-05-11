using System;
using System.Globalization;

namespace uri1013
{
    class Program
    {
        /*Faça um programa que leia três valores e apresente o maior dos três valores lidos seguido da mensagem “eh o maior”. Utilize a fórmula:
          
          MaiorAB = (a+b+abs(a-b)/2:

          Obs.: a fórmula apenas calcula o maior entre os dois primeiros (a e b). Um segundo passo, portanto é necessário para chegar no resultado
          esperado.

          Entrada
          O arquivo de entrada contém três valores inteiros.

          Saída
          Imprima o maior dos três valores seguido por um espaço e a mensagem "eh o maior".
         */
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

