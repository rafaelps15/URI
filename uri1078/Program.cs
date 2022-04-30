using System;

namespace uri1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            for (int i = 1; i <= 10; i++)
            {
                int n = int.Parse(Console.ReadLine());
                for (int j = 1; i <= 10; i++)
                {
                    tabuada = i * n;
                    Console.WriteLine(i + " x " + n + " = " + tabuada);
                }
            }
        }
    }
}
