using System;

namespace uri1050
{
    class Program
    {
        static void Main(string[] args)
        {

            int cod = int.Parse(Console.ReadLine());

            if (cod == 61)
            {
                Console.WriteLine("Brasilia");
            }
            else if (cod == 71)
            {
                Console.WriteLine("Salvador");
            }
            else if (cod == 11)
            {
                Console.WriteLine("Sao Paulo");
            }
            else if (cod == 21)
            {
                Console.WriteLine("Rio de Janeiro");
            }
            else if (cod == 32)
            {
                Console.WriteLine("Juiz de Fora");
            }
            else if (cod == 19)
            {
                Console.WriteLine("Campinas");
            }
            else if (cod == 27)
            {
                Console.WriteLine("Vitoria");
            }
            else if (cod == 31)
            {
                Console.WriteLine("Belo Horizonte");
            }
            else
            {
                Console.WriteLine("DDD nao cadastrado");
            }
        }
    }
}
