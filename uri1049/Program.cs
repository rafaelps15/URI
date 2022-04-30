using System;


namespace uri1049
{
    class Program
    {
        static void Main(string[] args)
        {
            string vert = Console.ReadLine();
            string ave = Console.ReadLine();
            string invert = Console.ReadLine();

            if (vert == "vertebrado")
            {
                if (ave == "ave")
                {
                    if (invert == "carnivoro")
                    {
                        Console.WriteLine("aguia");
                    }
                    else if (invert == "onivoro")
                    {
                        Console.WriteLine("pomba");
                    }
                }
                else if (ave == "mamifero")
                {
                    if (invert == "onivoro")
                    {
                        Console.WriteLine("homem");
                    }
                    else if (invert == "herbivoro")
                    {
                        Console.WriteLine("vaca");
                    }
                }
            }
            else if (vert == "invertebrado")
            {
                if (ave == "inseto")
                {
                    if (invert == "hematofago")
                    {
                        Console.WriteLine("pulga");
                    }
                    else if (invert == "herbivoro")
                    {
                        Console.WriteLine("lagarta");
                    }
                }
                else if (ave == "anelideo")
                {
                    if (invert == "hematofago")
                    {
                        Console.WriteLine("sanguessuga");
                    }
                    else if (invert == "onivoro")
                    {
                        Console.WriteLine("minhoca");
                    }
                }
            }
        }
    }
}