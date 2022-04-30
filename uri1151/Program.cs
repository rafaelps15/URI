using System;

namespace uri1151
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            int a = 0;
            int b = 1;

            for (int i = 0; i < num; i = i + 1)
            {
                if (i == num - 1)
                {
                    Console.WriteLine(a);
                }
                else
                {
                    Console.Write(a + " ");
                }
                int fibonacci = b;
                b = a;
                a = fibonacci + b;
            }
        }
    }
}
