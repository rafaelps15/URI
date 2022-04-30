using System;

namespace uri1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < 10000; i++)
            {
                int resto = 0;
                if (i % num == 2)
                {
                    resto = resto + i;
                    Console.WriteLine(resto);
                }
            }
        }
    }
}
