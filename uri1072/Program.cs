using System;

namespace uri1072
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int contIn = 0;
            int contOut = 0;
            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                if (x >= 10 && x <= 20)
                {
                    contIn++;
                }
                else
                {
                    contOut++;
                }
            }
            Console.WriteLine(contIn + " in");
            Console.WriteLine(contOut + " out");
        }
    }
}
