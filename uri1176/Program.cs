using System;

namespace uri1176
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int [] fibo = new int[61];
            fibo[0] = 0;
            fibo[1] = 1;

            int N = int.Parse(Console.ReadLine());

            for (int i = 2; i < N; i++)
            {
                fibo[i] = fibo[i - 1] + fibo[i - 2];

            }
            for (int i = 0; i < N; i++)
            {
                
                
            }
        }
    }
}
