using System;

namespace uri1001
{
    /*Leia 2 valores inteiros e armazene-os nas variáveis A e B. 
    Efetue a soma de A e B atribuindo o seu resultado na variável X. 
      
    Imprima X conforme exemplo apresentado abaixo. 
    Não apresente mensagem alguma além daquilo que está sendo especificado e não esqueça 
    de imprimir o fim de linha após o resultado,caso contrário, vocêreceberá "Presentation Error".
    */
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, x;

            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());

            x = a + b;

            Console.WriteLine("X = " + x);
        }
    }
}
